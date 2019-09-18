/* Lindsay Spencer
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * 17 Beginner C# Walkthrough Projects Step By Step
 * Project 1 : Create a Matching Pairs Icon Image Game
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPairsGame
{
    public partial class FormMatchingPairsGame : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public FormMatchingPairsGame()
        {
            InitializeComponent();
        }
    }
}
