using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class VeterinarioLogica
    {
        private VeterinarioDatos veterinarioDatos = new VeterinarioDatos();

        public List<Veterinario> Listar()
        {
            return veterinarioDatos.Listar();
        }

        public List<Veterinario> Buscar(string texto)
        {
            return veterinarioDatos.Buscar(texto.Trim());
        }

        public string ValidarTexto(string valor, string campo, int longitudMaxima)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return "El campo " + campo + " es obligatorio.";
            if (valor.Length > longitudMaxima)
                return "El campo " + campo + " admite máximo " + longitudMaxima + " caracteres.";
            return "";
        }

        public string ValidarTelefono(string telefono)
        {
            string mensaje = ValidarTexto(telefono, "teléfono", 20);
            if (mensaje != "") return mensaje;

            bool tieneNumero = false;
            int posicion = 0;
            int parentesisAbiertos = 0;
            foreach (char caracter in telefono)
            {
                if (caracter >= '0' && caracter <= '9')
                    tieneNumero = true;
                else if (caracter == '(')
                {
                    parentesisAbiertos++;
                    if (parentesisAbiertos > 1) return "Revisa los paréntesis del teléfono.";
                }
                else if (caracter == ')')
                {
                    parentesisAbiertos--;
                    if (parentesisAbiertos < 0) return "Revisa los paréntesis del teléfono.";
                }
                else if (caracter != ' ' && caracter != '-' && !(caracter == '+' && posicion == 0))
                    return "Usa números, espacios, guiones, paréntesis o un + al inicio.";
                posicion++;
            }
            if (!tieneNumero) return "El teléfono debe contener números.";
            if (parentesisAbiertos != 0) return "Revisa los paréntesis del teléfono.";
            return "";
        }

        public bool Guardar(Veterinario veterinario)
        {
            if (!EsValido(veterinario)) return false;
            return veterinarioDatos.Guardar(veterinario);
        }

        public bool Eliminar(int idVeterinario)
        {
            if (idVeterinario <= 0) return false;
            return veterinarioDatos.Eliminar(idVeterinario);
        }

        public bool Modificar(Veterinario veterinario)
        {
            if (veterinario.IdVeterinario <= 0 || !EsValido(veterinario)) return false;
            return veterinarioDatos.Modificar(veterinario);
        }

        private bool EsValido(Veterinario veterinario)
        {
            veterinario.Nombre = veterinario.Nombre.Trim();
            veterinario.Apellidos = veterinario.Apellidos.Trim();
            veterinario.Especialidad = veterinario.Especialidad.Trim();
            veterinario.Telefono = veterinario.Telefono.Trim();

            if (ValidarTexto(veterinario.Nombre, "nombre", 50) != "" ||
                ValidarTexto(veterinario.Apellidos, "apellidos", 80) != "" ||
                ValidarTexto(veterinario.Especialidad, "especialidad", 60) != "" ||
                ValidarTelefono(veterinario.Telefono) != "")
                return false;

            return true;
        }
    }
}
