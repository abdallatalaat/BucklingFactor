using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BucklingFactor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        public static double Bisector(double varied_variable, Func<double, double[], double> equation, double[] rest_args, double[] bc)
        {
            if (Math.Abs(equation(varied_variable, rest_args)) < 0.0000000000001 || bc[0] == bc[1]) {
                return varied_variable;
            }

            double new_value = 0.5 * (bc[0] + bc[1]);
            if (varied_variable == new_value) { return new_value; }
            if (equation(new_value, rest_args) * bc[0] > 0) { bc[0] = new_value; }
            else { bc[1] = new_value; }
            return Bisector(new_value, equation, rest_args, bc);

        }

        public static double Buckling_Equation_Sway(double k, double[] constants) 
        {
            double G_a = constants[0];
            double G_b = constants[1];
            return (G_a * G_b * Math.Pow(Math.PI / k, 2) - 36) / (6 * (G_a + G_b)) - (Math.PI / k) / (Math.Tan(Math.PI / k));
        }
        public static double Buckling_Equation_NoSway(double k, double[] constants) 
        {
            double G_a = constants[0];
            double G_b = constants[1];
            return 0.25 * G_a * G_b * Math.Pow(Math.PI / k, 2) + 0.5 * (G_a + G_b) * (1 - (Math.PI / k) / (Math.Tan(Math.PI / k))) + (Math.Tan(0.5 * Math.PI / k)) / (0.5 * Math.PI / k);
        }

    }

    

}
