using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace Lab7AvaloniaUI.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        var bitmap = new Bitmap("C:\\Users\\Satella\\source\\repos\\Lab7AvaloniaUI\\TRASZKA.JPG");
        MyImage.Source = bitmap;

    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        outp.Text = "";
        Dictionary<string, int> counts = new();

        if (inp.Text != null)
        {
            string seq = inp.Text.ToUpper();
            for (int i = 0; i <= seq.Length-4; i++)
            {
                string subseq = seq.Substring(i, 4);
                if (counts.ContainsKey(subseq))
                    counts[subseq]++;
                else
                    counts[subseq] = 1;
            }
            foreach (var pair in counts)
            {
                outp.Text += $"{pair.Key}: {pair.Value}\n";
            }
        }
    }
    private void MyImage_OnClick(object? sender, PointerPressedEventArgs e)
    {
        MyImage.Width = 400;  
        MyImage.Height = 400;
        traszka.Text = "TRASZKA:D";
    }
}
