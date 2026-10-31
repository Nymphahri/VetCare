using VetCare.UI.Datos;
using VetCare.UI.Modelos;

namespace VetCare.UI.Logica
{
    public class PropietarioLogica
    {
        private PropietarioDatos propietarioDatos = new PropietarioDatos();

        public List<Propietario> Listar()
        {
            return propietarioDatos.Listar();
        }

        public List<Propietario> Buscar(string texto)
        {
            return propietarioDatos.Buscar(texto.Trim());
        }

        public string ValidarTexto(string valor, string campo, int longitudMaxima)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return "El campo " + campo + " es obligatorio.";

            if (valor.Length > longitudMaxima)
                return "El campo " + campo + " admite máximo " + longitudMaxima + " caracteres.";

            return "";
        }

        public string ValidarCedula(string cedula)
        {
            string mensaje = ValidarTexto(cedula, "cédula", 20);
            if (mensaje != "") return mensaje;

            bool tieneLetraONumero = false;
            foreach (char caracter in cedula)
            {
                if (char.IsLetterOrDigit(caracter))
                    tieneLetraONumero = true;
                else if (caracter != '-' && caracter != ' ' && caracter != '.' && caracter != '/')
                    return "La cédula admite letras, números, espacios, guiones, puntos y barras.";
            }

            if (!tieneLetraONumero) return "La cédula debe contener letras o números.";
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

        public string ValidarCorreo(string correo)
        {
            if (correo == "") return "";
            if (correo.Length > 100) return "El correo admite máximo 100 caracteres.";

            int arroba = correo.IndexOf('@');
            int punto = correo.LastIndexOf('.');
            if (arroba <= 0 || arroba != correo.LastIndexOf('@') ||
                punto <= arroba + 1 || punto == correo.Length - 1 ||
                correo.StartsWith('.') || correo.Contains(".."))
                return "Escribe un correo como nombre@dominio.com.";

            foreach (char caracter in correo)
            {
                if (char.IsWhiteSpace(caracter) || char.IsControl(caracter))
                    return "El correo no admite espacios ni saltos de línea.";
            }

            return "";
        }

        public bool Guardar(Propietario propietario)
        {
            if (!EsValido(propietario)) return false;
            return propietarioDatos.Guardar(propietario);
        }

        public bool Eliminar(int idPropietario)
        {
            if (idPropietario <= 0) return false;
            return propietarioDatos.Eliminar(idPropietario);
        }

        public bool Modificar(Propietario propietario)
        {
            if (propietario.IdPropietario <= 0 || !EsValido(propietario)) return false;
            return propietarioDatos.Modificar(propietario);
        }

        private bool EsValido(Propietario propietario)
        {
            // Las reglas también se comprueban antes de acceder a los datos.
            if (ValidarCedula(propietario.Cedula) != "" ||
                ValidarTexto(propietario.Nombre, "nombre", 50) != "" ||
                ValidarTexto(propietario.Apellidos, "apellidos", 80) != "" ||
                ValidarTelefono(propietario.Telefono) != "" ||
                ValidarCorreo(propietario.Correo) != "")
                return false;

            return true;
        }
    }
}
