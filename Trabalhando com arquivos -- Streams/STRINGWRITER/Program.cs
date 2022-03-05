string textReaderText = "Primeira linha muuuuuuuito grande" +
                        "Segunda linha maiiior aindaaaaa"+
                        "Terceira linha nem se falaaaaaaa. \n\n" +
                        "Primeira linha muuuuuuuito grande" +
                        "Segunda linha maiiior aindaaaaa"+
                        "Terceira linha nem se falaaaaaaa. \n\n" +
                        "Primeira linha muuuuuuuito grande" +
                        "Segunda linha maiiior aindaaaaa"+
                        "Terceira linha nem se falaaaaaaa. \n\n" ;

Console.WriteLine($"Texto original :{textReaderText}");
string linha,paragrafo = null;

var sr = new StringReader(textReaderText);
while(true)
{
    linha =sr.ReadLine();
    if (linha != null)
    {
        // += é igual a  paragrafo = paragrafo + linha + " ";
        paragrafo += linha + " ";
    }
    else 
    {
        paragrafo += "\n";
        break;
    }

}

Console.WriteLine($"Texto modificado {paragrafo}");
int caracterLido;
char caracterConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while (true)
{
    caracterLido =sr.Read();
    if(caracterLido == -1)
    {
        break;
    }
    caracterConvertido =Convert.ToChar(caracterLido); 

    if(caracterConvertido == '.')
    {
        sw.Write("\n\n");
        sr.Read();
        sr.Read();

    }
    else
    {
        sw.Write(caracterConvertido);
    }


}
Console.WriteLine($" Texto armazenado no StringWriter \n {sw.ToString()}");
Console.ReadKey();