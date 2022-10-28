using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myTypeLaba3
{

    public struct complexNum
    {
        public int real;
        public int imaginary;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

    }


    public class ComplexLogic
    {
        private complexNum comp1 = new complexNum();
        private complexNum comp2 = new complexNum();

        public ComplexLogic(complexNum first, complexNum second)
        {
            comp1.real = first.real;
            comp1.imaginary = first.imaginary;

            comp2.real = second.real;
            comp2.imaginary = second.imaginary;
        }

        public complexNum summa(complexNum first, complexNum second)
        {
            //комплексные числа складывются сооьветвенно - реальная отдельно, мнимая отдельно            
            complexNum ans = new complexNum();

            ans.real = first.real + second.real;
            ans.imaginary = first.imaginary + second.imaginary; 

            return ans;
        }

        public complexNum difference(complexNum first, complexNum second)
        {
            complexNum ans = new complexNum();

            ans.real = first.real - second.real;
            ans.imaginary = first.imaginary - second.imaginary;

            return ans;
        }

        public complexNum multiplication(complexNum first, complexNum second)
        {
            complexNum ans = new complexNum();

            ans.real = (first.real * second.real) - (first.imaginary * second.imaginary);
            ans.imaginary = (first.real * second.imaginary) + (first.imaginary * second.real);

            return ans;
        }


        public complexNum division(complexNum first, complexNum second)
        {
            complexNum ans = new complexNum();

            ans.real = (first.real * second.real + first.imaginary * second.imaginary) / (second.real * second.real + second.imaginary * second.imaginary);
            ans.imaginary = (first.imaginary * second.real - first.real * second.imaginary) / (second.real * second.real + second.imaginary * second.imaginary);

            return ans;
        }


    }

}
