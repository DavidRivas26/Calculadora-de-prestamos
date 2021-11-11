using System;

namespace Logica
{
    public class Calcular
    {

        public double Operacion(int prestamo, int meses, double monto)
        {

            double devolucion = 0;
            double interes = 0;

            switch (prestamo)
            {
                case (int)OpcionesPrestamo.Personal:

                    switch (meses)
                    {

                        case (int)OpcionesMeses.Mes12:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 12;

                            break;
                        case (int)OpcionesMeses.Mes18:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 18;

                            break;
                        case (int)OpcionesMeses.Mes24:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 24;

                            break;
                        case (int)OpcionesMeses.Mes30:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 30;

                            break;
                        case (int)OpcionesMeses.Mes36:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 36;

                            break;
                        case (int)OpcionesMeses.Mes42:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 42;

                            break;
                        case (int)OpcionesMeses.Mes48:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 48;

                            break;
                        case (int)OpcionesMeses.Mes54:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 54;

                            break;
                        case (int)OpcionesMeses.Mes60:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 60;

                            break;
                        case (int)OpcionesMeses.Mes66:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 66;

                            break;
                        case (int)OpcionesMeses.Mes72:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 72;

                            break;
                        case (int)OpcionesMeses.Mes78:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 78;

                            break;
                        case (int)OpcionesMeses.Mes84:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 84;

                            break;
                        case (int)OpcionesMeses.Mes90:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 90;

                            break;
                        case (int)OpcionesMeses.Mes96:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 96;

                            break;
                        case (int)OpcionesMeses.Mes102:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 102;

                            break;
                        case (int)OpcionesMeses.Mes108:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 108;

                            break;
                        case (int)OpcionesMeses.Mes114:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 114;

                            break;
                        case (int)OpcionesMeses.Mes120:

                            interes = monto * 0.22;
                            devolucion = (monto + interes) / 120;

                            break;

                    }

                    break;
                case (int)OpcionesPrestamo.Automovil:

                    switch (meses)
                    {

                        case (int)OpcionesMeses.Mes12:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 12;

                            break;
                        case (int)OpcionesMeses.Mes18:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 18;

                            break;
                        case (int)OpcionesMeses.Mes24:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 24;

                            break;
                        case (int)OpcionesMeses.Mes30:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 30;

                            break;
                        case (int)OpcionesMeses.Mes36:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 36;

                            break;
                        case (int)OpcionesMeses.Mes42:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 42;

                            break;
                        case (int)OpcionesMeses.Mes48:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 48;

                            break;
                        case (int)OpcionesMeses.Mes54:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 54;

                            break;
                        case (int)OpcionesMeses.Mes60:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 60;

                            break;
                        case (int)OpcionesMeses.Mes66:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 66;

                            break;
                        case (int)OpcionesMeses.Mes72:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 72;

                            break;
                        case (int)OpcionesMeses.Mes78:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 78;

                            break;
                        case (int)OpcionesMeses.Mes84:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 84;

                            break;
                        case (int)OpcionesMeses.Mes90:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 90;

                            break;
                        case (int)OpcionesMeses.Mes96:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 96;

                            break;
                        case (int)OpcionesMeses.Mes102:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 102;

                            break;
                        case (int)OpcionesMeses.Mes108:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 108;

                            break;
                        case (int)OpcionesMeses.Mes114:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 114;

                            break;
                        case (int)OpcionesMeses.Mes120:

                            interes = monto * 0.12;
                            devolucion = (monto + interes) / 120;

                            break;

                    }

                    break;
                case (int)OpcionesPrestamo.Hipotecario:

                    switch (meses)
                    {

                        case (int)OpcionesMeses.Mes12:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 12;

                            break;
                        case (int)OpcionesMeses.Mes18:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 18;

                            break;
                        case (int)OpcionesMeses.Mes24:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 24;

                            break;
                        case (int)OpcionesMeses.Mes30:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 30;

                            break;
                        case (int)OpcionesMeses.Mes36:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 36;

                            break;
                        case (int)OpcionesMeses.Mes42:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 42;

                            break;
                        case (int)OpcionesMeses.Mes48:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 48;

                            break;
                        case (int)OpcionesMeses.Mes54:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 54;

                            break;
                        case (int)OpcionesMeses.Mes60:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 60;

                            break;
                        case (int)OpcionesMeses.Mes66:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 66;

                            break;
                        case (int)OpcionesMeses.Mes72:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 72;

                            break;
                        case (int)OpcionesMeses.Mes78:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 78;

                            break;
                        case (int)OpcionesMeses.Mes84:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 84;

                            break;
                        case (int)OpcionesMeses.Mes90:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 90;

                            break;
                        case (int)OpcionesMeses.Mes96:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 96;

                            break;
                        case (int)OpcionesMeses.Mes102:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 102;

                            break;
                        case (int)OpcionesMeses.Mes108:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 108;

                            break;
                        case (int)OpcionesMeses.Mes114:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 114;

                            break;
                        case (int)OpcionesMeses.Mes120:

                            interes = monto * 0.08;
                            devolucion = (monto + interes) / 120;

                            break;

                    }

                    break;
            }

            return devolucion;

        }


    }
}
