using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int quesNo = 0, trues = 0, falses = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
         

                switch (quesNo)
                { 
                    case 1:
                        if (textBox1.Text == "Antelope")
                        {
                            A.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            A.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "Book")
                        {
                            B.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            B.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cat")
                        {
                            C.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            C.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Dog")
                        {
                            D.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            D.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Elephant")
                        {
                            E.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            E.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Gorilla")
                        {
                            G.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            G.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "House")
                        {
                            H.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            H.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Jelly")
                        {
                            J.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            J.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Kite")
                        {
                            K.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            K.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "Lion")
                        {
                            L.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            L.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Monkey")
                        {
                            M.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            M.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Nest")
                        {
                            N.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            N.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Ocean")
                        {
                            O.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            O.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Queen")
                        {
                            Q.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            Q.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Rainbow")
                        {
                            R.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            R.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Tree")
                        {
                            T.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            T.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Violin")
                        {
                            V.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            V.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Whale")
                        {
                            W.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            W.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Yacht")
                        {
                            Y.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            Y.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Zebra")
                        {
                            Z.BackColor = Color.Green;
                            trues++;
                            trueLabel.Text = trues.ToString();
                        }
                        else
                        {
                            Z.BackColor = Color.Red;
                            falses++;
                            falseLabel.Text = falses.ToString();
                        }
                        break;
                }

            }
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next question";

            quesNo++;

            this.Text = quesNo.ToString();

            if (quesNo == 1)
            {
                richTextBox1.Text = "What is a type of swift-running, hoofed mammal with long, slender horns?";
                A.BackColor = Color.Yellow;
            }

            if (quesNo == 2)
            {
                richTextBox1.Text = "What is a collection of written or printed sheets bound together?";
                B.BackColor = Color.Yellow;
            }

            if (quesNo == 3)
            {
                richTextBox1.Text = "What is a furry, four-legged pet that likes to chase mice?";
                C.BackColor = Color.Yellow;
            }

            if (quesNo == 4)
            {
                richTextBox1.Text = "What is a loyal, four-legged animal that barks and wags its tail?";
                D.BackColor = Color.Yellow;
            }

            if (quesNo == 5)
            {
                richTextBox1.Text = "What is the largest land mammal with a long trunk and tusks?";
                E.BackColor = Color.Yellow;
            }

            if (quesNo == 6)
            {
                richTextBox1.Text = "What is a building where people live?";
                G.BackColor = Color.Yellow;
            }

            if (quesNo == 7)
            {
                richTextBox1.Text = "What is a sweet, jiggly dessert made from fruit juice and gelatin?";
                H.BackColor = Color.Yellow;
            }

            if (quesNo == 8)
            {
                richTextBox1.Text = "What is a light object made of paper or fabric that can be flown in the wind?";
                J.BackColor = Color.Yellow;
            }

            if (quesNo == 9)
            {
                richTextBox1.Text = "What is the king of the jungle with a big mane and a mighty roar?";
                K.BackColor = Color.Yellow;
            }

            if (quesNo == 10)
            {
                richTextBox1.Text = "What is a small, furry primate that likes to swing from trees?";
                L.BackColor = Color.Yellow;
            }

            if (quesNo == 11)
            {
                richTextBox1.Text = "What is a home built by a bird for its eggs and young?";
                M.BackColor = Color.Yellow;
            }

            if (quesNo == 12)
            {
                richTextBox1.Text = "What is the vast body of saltwater that covers most of the Earth's surface?";
                N.BackColor = Color.Yellow;
            }

            if (quesNo == 13)
            {
                richTextBox1.Text = "What is the female monarch of a kingdom?";
                O.BackColor = Color.Yellow;
            }

            if (quesNo == 14)
            {
                richTextBox1.Text = "What is a colorful arc that appears in the sky after rain?";
                Q.BackColor = Color.Yellow;
            }

            if (quesNo == 15)
            {
                richTextBox1.Text = "What is a tall, woody plant with branches and leaves?";
                R.BackColor = Color.Yellow;
            }

            if (quesNo == 16)
            {
                richTextBox1.Text = "What is a stringed instrument that is played with a bow?";
                T.BackColor = Color.Yellow;
            }

            if (quesNo == 17)
            {
                richTextBox1.Text = "What is the largest mammal in the world?";
                V.BackColor = Color.Yellow;
            }

            if (quesNo == 18)
            {
                richTextBox1.Text = "What is a large, luxurious sailboat?";
                W.BackColor = Color.Yellow;
            }

            if (quesNo == 19)
            {
                richTextBox1.Text = "What is a black-and-white striped horse?";
                Y.BackColor = Color.Yellow;
            }

            if (quesNo == 20)
            {
                richTextBox1.Text = "What is a black-and-white striped horse?";
                Z.BackColor = Color.Yellow;
            }

        }
    }
}
