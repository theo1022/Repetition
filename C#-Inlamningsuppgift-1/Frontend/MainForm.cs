using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend.Modules;
using Frontend.Modules.Browser;
using Frontend.Modules.Plot;
using Microsoft.VisualBasic.CompilerServices;

namespace Frontend
{
    public partial class MainForm : Form
    {
        //TODO Vad är skillnaden på en vanlig metod och en konstruktor som 'MainForm'?
        // Answer: A constructor is called when an instance of a class is created to initialize the object
        // A method can be called from an object to execute a block of code to for example modify the object or return a value
        public MainForm()
        {
            InitializeComponent();

            var menuManager = new MenuManager(this);
            menuManager.SwitchToMainMenu();
        }
    }
}