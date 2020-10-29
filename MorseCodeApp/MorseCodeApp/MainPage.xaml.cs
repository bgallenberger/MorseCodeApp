using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCodeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string letter = "";
        string word = "";
        string sentence = "";

        void OnSpaceClicked(object sender, System.EventArgs e)
        {
            string tempLetter = Char.ToString(Morse.MorseCoder(letter));
            if (letter == "")
            {
                letter = tempLetter;
                word += letter;
                output.Text = $"Sentence: {sentence}\nWord: {word}\nLetter: {letter}";
            }
            else if (letter == " ")
            {
                sentence += word;
                letter = "";
                word = "";
                output.Text = $"Sentence: {sentence}\nWord: {word}\nLetter: {letter}";
            }
            else
            {
                if(tempLetter != "?")
                {
                    word += tempLetter;
                    letter = "";
                    output.Text = $"Sentence: {sentence}\nWord: {word}\nLetter: {letter}";
                }
                else
                {
                    letter = "";
                    output.Text = "Invalid Letter";
                }
            }
        }
        void OnDotClicked(object sender, System.EventArgs e)
        {
            letter += ".";
            output.Text = $"Sentence: {sentence}\nWord: {word}\nLetter: {letter}";
        }
        void OnDashClicked(object sender, System.EventArgs e)
        {
            letter += "-";
            output.Text = $"Sentence: {sentence}\nWord: {word}\nLetter: {letter}";
        }
    }
}
