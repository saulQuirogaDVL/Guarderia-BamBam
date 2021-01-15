using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    [Serializable]
    public class Login
    {
        public String Cuenta { get; set; }
        public String Pass { get; set; }
        public String Tipo { get; set; }

        public Login(string cuenta, string pass, string tipo)
        {
            Cuenta = cuenta;
            Pass = pass;
            Tipo = tipo;
        }

        public bool crear_Sesion()
        {
            using (Guarderia_BamBamEntitiess BD= new Guarderia_BamBamEntitiess())
            {
                //admins

                //tutor
                if (Tipo == "Tutor")
                {
                    Tutor tutor = new Tutor();
                    if (BD.Tutor.Find(Cuenta) != null)
                    {
                        tutor = BD.Tutor.Find(Cuenta);
                        if (Pass == tutor.contrasenia)
                        {
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else {
                    if (Tipo == "Profesor")
                    {
                        profesores profesores = new profesores();
                        if (BD.profesores.Find(Cuenta) != null)
                        {
                            profesores = BD.profesores.Find(Cuenta);
                            if (Pass == profesores.contrasenia)
                            {
                                return true;
                            }
                            else { return false; }
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                //Profesor

                
            }
        }
    }
}