﻿using System.Threading.Tasks;

namespace Tesseract.ConsoleDemo.Utils;

internal class Statics
{
    
    /// <summary>
    ///     The prompt indicating the output section.
    /// </summary>
    public const string RestartPrompt =
        "Press any key to analize another image or ESC to end.";


    /// <summary>
    ///     Ask Model Language to use in OCR.
    /// </summary>
    public const string Language
        = "Enter the [green]language to use in OCR[/]:";

     /// <summary>
    ///     The prompt asking the user to enter the path to the model folder.
    /// </summary>
    public const string ModelInputPrompt
        = "Enter the path to the [yellow]models folder[/]:";

    /// <summary>
    ///     The prompt asking the user to enter the path to the model folder.
    /// </summary>
    public const string ImageInput
        = "Enter the path to the [yellow]Image[/]:";

    /// <summary>
    ///     The prompt asking the user to enter the path to the model folder.
    /// </summary>
    public const string textOutput
        = "Enter the Output path to the [green]Text[/]:";


}