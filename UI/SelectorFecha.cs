using System.ComponentModel;
using System.Globalization;
using Guna.UI2.WinForms;

namespace VetCare.UI.UI
{
    public class SelectorFecha : Guna2Button
    {
        private static readonly CultureInfo espanol = new("es-CR");
        private DateTime valor = DateTime.Today;
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime MinDate => new(1753, 1, 1);
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime MaxDate => new(9998, 12, 31);
        [DefaultValue(false)]
        public bool IncluirHora { get; set; }
        [DefaultValue(false)]
        public bool FechaLarga { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Value
        {
            get => valor;
            set
            {
                DateTime nueva = IncluirHora ? value : value.Date;
                if (nueva.Date < MinDate || nueva.Date > MaxDate) throw new ArgumentOutOfRangeException(nameof(value));
                bool cambio = nueva != valor;
                valor = nueva;
                ActualizarTexto();
                if (cambio) ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public event EventHandler? ValueChanged;

        public SelectorFecha()
        {
            BorderRadius = 10;
            Cursor = Cursors.Hand;
            FillColor = Color.FromArgb(230, 240, 235);
            ForeColor = Color.FromArgb(21, 62, 61);
            HoverState.FillColor = Color.FromArgb(217, 234, 225);
            ActualizarTexto();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ActualizarTexto();
        }

        private void ActualizarTexto()
        {
            string formato = FechaLarga ? "dddd d 'de' MMMM 'de' yyyy" : IncluirHora ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy";
            Text = valor.ToString(formato, espanol) + "  ▾";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            DateTime elegida = Value.Date;
            DateTime mes = new DateTime(Value.Year, Value.Month, 1);
            var ventana = new ToolStripDropDown { Padding = new Padding(1), BackColor = Color.FromArgb(200, 220, 212) };
            var tabla = new TableLayoutPanel
            {
                BackColor = Color.White, ColumnCount = 7, RowCount = IncluirHora ? 9 : 8,
                Size = new Size(Math.Max(Width, LogicalToDeviceUnits(280)), LogicalToDeviceUnits(IncluirHora ? 312 : 264)), TabStop = false
            };
            for (int i = 0; i < 7; i++)
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
            for (int i = 0; i < tabla.RowCount; i++)
                tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tabla.RowCount));

            Button Boton(string texto)
            {
                var boton = new Button { Text = texto, Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(1), BackColor = Color.White, ForeColor = Color.FromArgb(21, 62, 61) };
                boton.FlatAppearance.BorderSize = 0;
                boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 238, 231);
                return boton;
            }

            Button anterior = Boton("‹"), siguiente = Boton("›");
            anterior.AccessibleName = "Mes anterior";
            siguiente.AccessibleName = "Mes siguiente";
            var titulo = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            tabla.Controls.Add(anterior, 0, 0);
            tabla.Controls.Add(titulo, 1, 0);
            tabla.SetColumnSpan(titulo, 3);
            var anio = new NumericUpDown { Minimum = MinDate.Year, Maximum = MaxDate.Year, Value = mes.Year,
                Dock = DockStyle.Fill, AccessibleName = "Año" };
            tabla.Controls.Add(anio, 4, 0);
            tabla.SetColumnSpan(anio, 2);
            tabla.Controls.Add(siguiente, 6, 0);
            string[] semana = { "Lu", "Ma", "Mi", "Ju", "Vi", "Sá", "Do" };
            var dias = new Button[42];
            for (int i = 0; i < semana.Length; i++)
                tabla.Controls.Add(new Label { Text = semana[i], Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter }, i, 1);
            for (int i = 0; i < dias.Length; i++)
            {
                Button dia = Boton("");
                dias[i] = dia;
                tabla.Controls.Add(dia, i % 7, 2 + i / 7);
                dia.Click += (_, _) =>
                {
                    elegida = (DateTime)dia.Tag!;
                    if (IncluirHora) MostrarMes();
                    else
                    {
                        ventana.Close();
                        Value = elegida;
                    }
                };
            }
            void MostrarMes()
            {
                anio.Value = mes.Year;
                titulo.Text = mes.ToString("MMMM", espanol);
                anterior.Enabled = mes > MinDate;
                siguiente.Enabled = mes.Year != MaxDate.Year || mes.Month != MaxDate.Month;
                int inicio = ((int)mes.DayOfWeek + 6) % 7;
                int cantidad = DateTime.DaysInMonth(mes.Year, mes.Month);
                for (int i = 0; i < dias.Length; i++)
                {
                    Button dia = dias[i];
                    int numero = i - inicio + 1;
                    dia.Visible = numero >= 1 && numero <= cantidad;
                    if (numero < 1 || numero > cantidad) continue;
                    DateTime fecha = mes.AddDays(numero - 1);
                    dia.Text = numero.ToString();
                    dia.Tag = fecha;
                    dia.AccessibleName = fecha.ToString("D", espanol);
                    dia.BackColor = fecha == elegida ? Color.FromArgb(17, 107, 94) : Color.White;
                    dia.ForeColor = fecha == elegida ? Color.White : Color.FromArgb(21, 62, 61);
                }
            }
            anio.ValueChanged += (_, _) =>
            {
                mes = new DateTime((int)anio.Value, mes.Month, 1);
                MostrarMes();
            };
            if (IncluirHora)
            {
                var hora = new DateTimePicker { Format = DateTimePickerFormat.Custom, CustomFormat = "HH:mm",
                    ShowUpDown = true, Value = Value, Dock = DockStyle.Fill, AccessibleName = "Hora de la cita" };
                tabla.Controls.Add(new Label { Text = "Hora", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 8);
                tabla.Controls.Add(hora, 1, 8);
                tabla.SetColumnSpan(hora, 3);
                Button aceptar = Boton("Aceptar");
                tabla.Controls.Add(aceptar, 4, 8);
                tabla.SetColumnSpan(aceptar, 3);
                aceptar.Click += (_, _) =>
                {
                    DateTime seleccion = elegida.AddHours(hora.Value.Hour).AddMinutes(hora.Value.Minute);
                    ventana.Close();
                    Value = seleccion;
                };
            }
            anterior.Click += (_, _) => { mes = mes.AddMonths(-1); MostrarMes(); };
            siguiente.Click += (_, _) => { mes = mes.AddMonths(1); MostrarMes(); };
            MostrarMes();
            ventana.Items.Add(new ToolStripControlHost(tabla) { Margin = Padding.Empty, Padding = Padding.Empty });
            ventana.Closed += (_, _) => BeginInvoke(new Action(ventana.Dispose));
            ventana.Show(this, new Point(0, Height));
        }
    }
}
