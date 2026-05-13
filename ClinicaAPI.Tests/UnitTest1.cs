using Xunit;
using ClinicaAPI.Models;

namespace ClinicaAPI.Tests
{
    public class PacienteTests
    {
        [Fact]
        public void Paciente_Debe_Guardar_Nombre()
        {
            var paciente = new Paciente
            {
                Nombre = "Juan Perez"
            };

            Assert.Equal("Juan Perez", paciente.Nombre);
        }

        [Fact]
        public void Paciente_Debe_Guardar_Edad()
        {
            var paciente = new Paciente
            {
                Edad = 25
            };

            Assert.Equal(25, paciente.Edad);
        }

        [Fact]
        public void Paciente_Debe_Guardar_Diagnostico()
        {
            var paciente = new Paciente
            {
                Diagnostico = "Gripe"
            };

            Assert.Equal("Gripe", paciente.Diagnostico);
        }

        [Fact]
        public void Paciente_Debe_Guardar_Telefono()
        {
            var paciente = new Paciente
            {
                Telefono = "987654321"
            };

            Assert.Equal("987654321", paciente.Telefono);
        }

        [Fact]
        public void Paciente_Debe_Guardar_Correo()
        {
            var paciente = new Paciente
            {
                CorreoElectronico = "juan@correo.com"
            };

            Assert.Contains("@", paciente.CorreoElectronico);
        }

        [Fact]
        public void Paciente_Nombre_No_Debe_Ser_Vacio()
        {
            var paciente = new Paciente
            {
                Nombre = "Carlos"
            };

            Assert.False(string.IsNullOrWhiteSpace(paciente.Nombre));
        }

        [Fact]
        public void Paciente_Edad_Debe_Ser_Mayor_A_Cero()
        {
            var paciente = new Paciente
            {
                Edad = 30
            };

            Assert.True(paciente.Edad > 0);
        }
    }
}