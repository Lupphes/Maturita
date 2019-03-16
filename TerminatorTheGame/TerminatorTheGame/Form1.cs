using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminatorTheGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            Character character = new Character("Terminator", 3001, 7000,2000, 0);
        }

        private void InitializeGame()
        {
            if (!File.Exists(@"C:\Users\ondre\OneDrive\Škola\PVA\TerminatorTheGame\TerminatorTheGame\bin\Debug\save.txt"))
            {
                this.Hide();
                File.Create(@"C:\Users\ondre\OneDrive\Škola\PVA\TerminatorTheGame\TerminatorTheGame\bin\Debug\save.txt");
                CreateNewCharacter createNewCharacter = new CreateNewCharacter();
                createNewCharacter.Show();
                return;
            }
            
            try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader("TestFile.txt"))
                    {
                        string line;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    rtbMain.Text += e.Message;
                }
            }
        }

    }

    class Character
    {
        private string _name;
        private int _attack;
        private int _health;
        private int _defence;
        private int _luck;
        private int charisma;

        public Character(string name, int attack, int health, int defence, int luck)
        {
            _name = name;
            _attack = attack;
            _health = health;
            _defence = defence;
            _luck = luck;
        }

        public void Talk(Character character)
        {
            
        }
    }