using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace textdwconverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool ConversionError = false;
        public bool _tableIsLoaded = false;
        public Dictionary<char,char> tablilladeconversion = new Dictionary<char,char>();
        public static string _stringgenerarcsv = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyzÁÉÍÓÚáéíóúü1234567890¡!¿?.,:{}[]()ªº/♪%&$+-_€#→";
        public void btn_convertir_click(object sender, RoutedEventArgs e)
        {
            ConversionError = false;
            string _textoAConvertir = textilloOriginal.Text;
           
            textilloConverso.Text = convertem(textilloOriginal.Text);
            if (ConversionError)
            {
                MessageBox.Show("There's wrong characters in the line!", "Done", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public string convertem(string textopaconverti)
        {
            bool filtroOn = true;
            string _textoAConvertir = textopaconverti;
            string _textoYaConvertido = _textoAConvertir;
            char[] chars = _textoAConvertir.ToCharArray();
            int contadorcaracteres = 0;

            for (int i = 0; i < _textoAConvertir.Length; i++)
            {
                bool pasadoporlatabla = false;
                if (filtroOn)
                {
                    if (chars[i] == '<')
                    {
                        filtroOn = false;
                    }
                }
                if (filtroOn)
                {
                    if (_tableIsLoaded)
                    {
                        if (tablilladeconversion.ContainsKey(chars[i]))
                        {
                            chars[i] = tablilladeconversion[chars[i]];
                            pasadoporlatabla = true;
                        }

                    }
                    if(!pasadoporlatabla)
                    {
                        switch (chars[i])
                        {

                            case 'a':
                                chars[i] = 'ａ';
                                break;
                            case 'b':
                                chars[i] = 'ｂ';
                                break;
                            case 'c':
                                chars[i] = 'ｃ';
                                break;
                            case 'd':
                                chars[i] = 'ｄ';
                                break;
                            case 'e':
                                chars[i] = 'ｅ';
                                break;
                            case 'f':
                                chars[i] = 'ｆ';
                                break;
                            case 'g':
                                chars[i] = 'ｇ';
                                break;
                            case 'h':
                                chars[i] = 'ｈ';
                                break;
                            case 'i':
                                chars[i] = 'ｉ';
                                break;
                            case 'j':
                                chars[i] = 'ｊ';
                                break;
                            case 'k':
                                chars[i] = 'ｋ';
                                break;
                            case 'l':
                                chars[i] = 'ｌ';
                                break;
                            case 'm':
                                chars[i] = 'ｍ';
                                break;
                            case 'n':
                                chars[i] = 'ｎ';
                                break;
                            case 'ñ':
                                chars[i] = 'ネ';
                                break;
                            case 'o':
                                chars[i] = 'ｏ';
                                break;
                            case 'p':
                                chars[i] = 'ｐ';
                                break;
                            case 'q':
                                chars[i] = 'ｑ';
                                break;
                            case 'r':
                                chars[i] = 'ｒ';
                                break;
                            case 's':
                                chars[i] = 'ｓ';
                                break;
                            case 't':
                                chars[i] = 'ｔ';
                                break;
                            case 'u':
                                chars[i] = 'ｕ';
                                break;
                            case 'v':
                                chars[i] = 'ｖ';
                                break;
                            case 'w':
                                chars[i] = 'ｗ';
                                break;
                            case 'x':
                                chars[i] = 'ｘ';
                                break;
                            case 'y':
                                chars[i] = 'ｙ';
                                break;
                            case 'z':
                                chars[i] = 'ｚ';
                                break;
                            case 'A':
                                chars[i] = 'Ａ';
                                break;
                            case 'B':
                                chars[i] = 'Ｂ';
                                break;
                            case 'C':
                                chars[i] = 'Ｃ';
                                break;
                            case 'D':
                                chars[i] = 'Ｄ';
                                break;
                            case 'E':
                                chars[i] = 'Ｅ';
                                break;
                            case 'F':
                                chars[i] = 'Ｆ';
                                break;
                            case 'G':
                                chars[i] = 'Ｇ';
                                break;
                            case 'H':
                                chars[i] = 'Ｈ';
                                break;
                            case 'I':
                                chars[i] = 'Ｉ';
                                break;
                            case 'J':
                                chars[i] = 'Ｊ';
                                break;
                            case 'K':
                                chars[i] = 'Ｋ';
                                break;
                            case 'L':
                                chars[i] = 'Ｌ';
                                break;
                            case 'M':
                                chars[i] = 'Ｍ';
                                break;
                            case 'N':
                                chars[i] = 'Ｎ';
                                break;
                            case 'Ñ':
                                chars[i] = 'メ';
                                break;
                            case 'O':
                                chars[i] = 'Ｏ';
                                break;
                            case 'P':
                                chars[i] = 'Ｐ';
                                break;
                            case 'Q':
                                chars[i] = 'Ｑ';
                                break;
                            case 'R':
                                chars[i] = 'Ｒ';
                                break;
                            case 'S':
                                chars[i] = 'Ｓ';
                                break;
                            case 'T':
                                chars[i] = 'Ｔ';
                                break;
                            case 'U':
                                chars[i] = 'Ｕ';
                                break;
                            case 'V':
                                chars[i] = 'Ｖ';
                                break;
                            case 'W':
                                chars[i] = 'Ｗ';
                                break;
                            case 'X':
                                chars[i] = 'Ｘ';
                                break;
                            case 'Y':
                                chars[i] = 'Ｙ';
                                break;
                            case 'Z':
                                chars[i] = 'Ｚ';
                                break;
                            case 'á':
                                chars[i] = 'ト';
                                break;
                            case 'é':
                                chars[i] = 'エ';
                                break;
                            case 'í':
                                chars[i] = 'ナ';
                                break;
                            case 'ó':
                                chars[i] = 'ニ';
                                break;
                            case 'ú':
                                chars[i] = 'ヌ';
                                break;
                            case 'Á':
                                chars[i] = 'ホ';
                                break;
                            case 'É':
                                chars[i] = 'ム';
                                break;
                            case 'Í':
                                chars[i] = 'ボ';
                                break;
                            case 'Ó':
                                chars[i] = 'ポ';
                                break;
                            case 'Ú':
                                chars[i] = 'マ';
                                break;
                            case '?':
                                chars[i] = '？';
                                break;
                            case '¿':
                                chars[i] = 'あ';
                                break;
                            case '!':
                                chars[i] = '！';
                                break;
                            case '¡':
                                chars[i] = 'い';
                                break;
                            case '.':
                                chars[i] = '・';
                                break;
                            case ',':
                                chars[i] = '、';
                                break;
                            case '1':
                                chars[i] = '１';
                                break;
                            case '2':
                                chars[i] = '２';
                                break;
                            case '3':
                                chars[i] = '３';
                                break;
                            case '4':
                                chars[i] = '４';
                                break;
                            case '5':
                                chars[i] = '５';
                                break;
                            case '6':
                                chars[i] = '６';
                                break;
                            case '7':
                                chars[i] = '７';
                                break;
                            case '8':
                                chars[i] = '８';
                                break;
                            case '9':
                                chars[i] = '９';
                                break;
                            case '0':
                                chars[i] = '０';
                                break;
                            case ' ':
                                chars[i] = '　';
                                break;
                            case '{':
                                chars[i] = '｛';
                                break;
                            case '}':
                                chars[i] = '｝';
                                break;
                            case '｛':
                                chars[i] = '｛';
                                break;
                            case '｝':
                                chars[i] = '｝';
                                break;
                            case ':':
                                chars[i] = '：';
                                break;
                            case 'ª':
                                chars[i] = '流';
                                break;
                            case '(':
                                chars[i] = '（';
                                break;
                            case ')':
                                chars[i] = '）';
                                break;
                            case 'º':
                                chars[i] = '竜';
                                break;
                            case '"':
                                chars[i] = '了';
                                break;
                            case '/':
                                chars[i] = '／';
                                break;
                            case '→':
                                chars[i] = '→';
                                break;
                            case '♪':
                                chars[i] = '♪';
                                break;
                            case '[':
                                chars[i] = '『';
                                break;
                            case ']':
                                chars[i] = '』';
                                break;
                            case '%':
                                chars[i] = '％';
                                break;
                            case '&':
                                chars[i] = '＆';
                                break;
                            case '$':
                                chars[i] = '…';
                                break;
                            case '+':
                                chars[i] = '＋';
                                break;
                            case '€':
                                chars[i] = '×';
                                break;
                            case '_':
                                chars[i] = 'ー';
                                break;
                            case '　':
                                chars[i] = '　';
                                break;
                            case '-':
                                chars[i] = '－';
                                break;
                            case '#':
                                chars[i] = '旅';
                                break;
                            case 'ü':
                                chars[i] = 'ぅ';
                                break;
                            case 'ａ':
                                chars[i] = '右';
                                break;
                            case 'ｂ':
                                chars[i] = '習';
                                break;
                            case 'ｃ':
                                chars[i] = '枚';
                                break;
                            case 'ｄ':
                                chars[i] = '費';
                                break;
                            case '\n':
                                break;
                            case '\r':
                                break;
                            default:
                                chars[i] = '*';
                                ConversionError = true;
                                break;
                        }
                    }
                    contadorcaracteres++;
                }
                else
                {
                    if (chars[i] == '>')
                    {
                        filtroOn = true;
                    }
                }
            }
            _textoYaConvertido = new string(chars);
            _textoYaConvertido = _textoYaConvertido.Replace("\r\n", String.Empty);
            textilloNumChar.Text = contadorcaracteres.ToString();
            return _textoYaConvertido;
            
        }

        private void textilloOriginal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btn_convertir_click(sender,e);
            }
        }

        private void botoncsv_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("The file will be edited.\nDo you want to do this?", "Confirmation", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = ".csv script files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == true)
                {
                    ConversionError = false;
                    List<string[]> list = new List<string[]>();
                    using (TextFieldParser csvParser = new TextFieldParser(openFileDialog.FileName))
                    {
                        csvParser.CommentTokens = new string[] { "#" };
                        csvParser.SetDelimiters(new string[] { ";" });


                        // Skip the row with the column names
                        csvParser.ReadLine();

                        while (!csvParser.EndOfData)
                        {
                            // Read current line fields, pointer moves to the next line.
                            string[] fields = csvParser.ReadFields();
                            list.Add(fields);
                        }
                    }
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.WriteLine("ScriptFile;ScriptSection;InstructionNumber;InstructionOffset;OriginalText;Translated;CodedTranslated");
                            for (int i= 0; i< list.Count; i++)
                            {
                                sw.WriteLine(list[i][0] + ";" + list[i][1] + ";" + list[i][2] + ";" + list[i][3] + ";" + list[i][4] + ";"+ list[i][5] + ";" + convertem(list[i][5]));
                            }
                        }
                    }
                }
                if (ConversionError)
                {
                    MessageBox.Show("There's been errors in 1 or more lines!", "Errors", MessageBoxButton.OK, MessageBoxImage.Error);
                    MessageBox.Show("There's been errors in 1 or more lines!", "Errors", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Codification done!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void botonmulti_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("The files will be edited.\nDo you want to do this?\nIf yes, select any file in the folder you want to convert.", "Confirmation", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                string archivosmalos = "";
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = ".csv script files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == true)
                {
                    
                    foreach (var file in Directory.GetFiles(openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf('\\'))))
                    {
                        ConversionError = false;
                        List<string[]> list = new List<string[]>();
                        using (TextFieldParser csvParser = new TextFieldParser(file))
                        {
                            csvParser.CommentTokens = new string[] { "#" };
                            csvParser.SetDelimiters(new string[] { ";" });


                            // Skip the row with the column names
                            csvParser.ReadLine();

                            while (!csvParser.EndOfData)
                            {
                                // Read current line fields, pointer moves to the next line.
                                string[] fields = csvParser.ReadFields();
                                list.Add(fields);
                            }
                        }
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine("ScriptFile;ScriptSection;InstructionNumber;InstructionOffset;OriginalText;Translated;CodedTranslated");
                                for (int i = 0; i < list.Count; i++)
                                {
                                    sw.WriteLine(list[i][0] + ";" + list[i][1] + ";" + list[i][2] + ";" + list[i][3] + ";" + list[i][4] + ";" + list[i][5] + ";" + convertem(list[i][5]));
                                }
                            }
                        }
                        if (ConversionError)
                        {
                            archivosmalos+= file.Substring(file.LastIndexOf('\\') + 1) + "\n";
                        }
                    }
                }
                if (archivosmalos!="")
                {
                    MessageBox.Show("There's been errors in the following files!\n"+ archivosmalos, "Errors", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Codification done!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void botoncheckmulti_Click(object sender, RoutedEventArgs e)
        {
            string archivosmalos = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ".csv script files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == true)
            {

                foreach (var file in Directory.GetFiles(openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf('\\'))))
                {
                    string lineserror = "";
                    ConversionError = false;
                    List<string[]> list = new List<string[]>();
                    using (TextFieldParser csvParser = new TextFieldParser(file))
                    {
                        csvParser.CommentTokens = new string[] { "#" };
                        csvParser.SetDelimiters(new string[] { ";" });


                        // Skip the row with the column names
                        csvParser.ReadLine();

                        while (!csvParser.EndOfData)
                        {
                            // Read current line fields, pointer moves to the next line.
                            string[] fields = csvParser.ReadFields();
                            list.Add(fields);
                        }
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i][5].Length > 0)
                        {
                            if (list[i][5].Substring(list[i][5].Length - 6) != "<0D00>"  && list[i][5].Substring(list[i][5].Length - 7,6) != "<0D00>")
                            {
                                ConversionError = true;
                                lineserror += (i+2) + ", ";
                            }
                        }
                    }
                    if (ConversionError)
                    {
                        archivosmalos += file.Substring(file.LastIndexOf('\\') + 1) +" - line: " + lineserror + "\n";
                    }
                }
            }
            if (archivosmalos != "")
            {
                MessageBox.Show("There's been closing errors in the following files!\n" + archivosmalos, "Errors", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("All fields are correclty closed!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void boton_crearlista_Click(object sender, RoutedEventArgs e)
        {
            string convertidodefault = convertem(_stringgenerarcsv);
            char[] charsvanilla = _stringgenerarcsv.ToCharArray();
            char[] charsconverted = convertidodefault.ToCharArray();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".csv chartable files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == true)
            {
               
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {

                        sw.WriteLine("Original;Converted");
                        for (int i = 0; i < charsvanilla.Length; i++)
                        {
                            sw.WriteLine(charsvanilla[i] + ";" + charsconverted[i]);
                        }
                    }
                }
                MessageBox.Show("Default table created!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            }
                
        }

        private void boton_cargarlista_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ".csv chartable files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == true)
            {
                tablilladeconversion.Clear();
                using (TextFieldParser csvParser = new TextFieldParser(openFileDialog.FileName))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { ";" });
                    csvParser.HasFieldsEnclosedInQuotes = false;


                    // Skip the row with the column names
                    csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();
                        tablilladeconversion.Add(Convert.ToChar(fields[0]), Convert.ToChar(fields[1]));
                    }
                }
                _tableIsLoaded = true;
                Textillocustomtable.Content = "Custom table loaded";
                MessageBox.Show("Custom table loaded!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
