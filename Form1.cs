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

        //сложение
        private void button1_Click(object sender, EventArgs e)
        {
            ComplexLogic ans = new ComplexLogic(textFirstNum.Text, textSecondNum.Text);
            textAnswer.Text = "Ответ " + ans.summa();
        }

        //вычитание
        private void button2_Click(object sender, EventArgs e)
        {
            ComplexLogic ans = new ComplexLogic(textFirstNum.Text, textSecondNum.Text);
            textAnswer.Text = "Ответ " + ans.difference();
        }


        //деление
        private void button3_Click(object sender, EventArgs e)
        {
            ComplexLogic ans = new ComplexLogic(textFirstNum.Text, textSecondNum.Text);
            textAnswer.Text = "Ответ " + ans.division();
        }


        //умножение
        private void button4_Click(object sender, EventArgs e)
        {
            ComplexLogic ans = new ComplexLogic(textFirstNum.Text, textSecondNum.Text);
            textAnswer.Text = "Ответ " + ans.multiplication();
        }
    }


    public class ComplexLogic //R+i(Im)
    {
        private complexNum comp1 = new complexNum();
        private complexNum comp2 = new complexNum();

        private complexNum ans = new complexNum();

        public ComplexLogic(String first, String second)
        {
            comp1 = makeComplex(first);
            comp2 = makeComplex(second);
            
        }

        //метод для превращения входной строки в комплексное число
        private complexNum makeComplex(String num)
        {
            complexNum ans = new complexNum();

            String[] RealAndIm = num.Split(new string[] { "+i" }, StringSplitOptions.None); // разделяем строку на действительную и мнимую части

            ans.real = int.Parse(RealAndIm[0]);
            ans.imaginary = int.Parse(RealAndIm[1]);

            return ans; 
        }

        public complexNum summa()
        {
            //комплексные числа складывются сооьветвенно - реальная отдельно, мнимая отдельно            
            

            ans.real = comp1.real + comp2.real;
            ans.imaginary = comp1.imaginary + comp2.imaginary; 

            return ans;
        }

        public complexNum difference()
        {
            //complexNum ans = new complexNum();

            ans.real = comp1.real - comp2.real;
            ans.imaginary = comp1.imaginary - comp2.imaginary;

            return ans;
        }

        public complexNum multiplication()
        {
            //complexNum ans = new complexNum();

            ans.real = (comp1.real * comp2.real) - (comp1.imaginary * comp2.imaginary);
            ans.imaginary = (comp1.real * comp2.imaginary) + (comp1.imaginary * comp2.real);

            return ans;
        }


        public complexNum division()
        {
            //complexNum ans = new complexNum();

            ans.real = (comp1.real * comp2.real + comp1.imaginary * comp2.imaginary) / (comp2.real * comp2.real + comp2.imaginary * comp2.imaginary);
            ans.imaginary = (comp1.imaginary * comp2.real - comp1.real * comp2.imaginary) / (comp2.real * comp2.real + comp2.imaginary * comp2.imaginary);

            return ans;
        }


    }

}
