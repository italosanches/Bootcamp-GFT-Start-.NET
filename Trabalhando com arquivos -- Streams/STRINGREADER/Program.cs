﻿using System.Text;
var sb = new StringBuilder();

sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("Segunda linha");
sb.AppendLine("e o fim");

using var sr = new StringReader(sb.ToString());
var buffer = new char [10];
var tamanho = 0;

do
{
    // limpando o buffer
    buffer = new char [10];
    tamanho = sr.Read(buffer);
    Console.Write(string.Join("",buffer));
    
} while (tamanho >= buffer.Length);
Console.ReadKey();