namespace Exemplo_Colecoes.helper
{
    public class OperacoesArray
    {
        public string[] ConverterParaArrayString(int [] array)
        {
            return Array.ConvertAll(array,elemento => elemento.ToString());
        }
        public void RedimensionarArray(ref int [] array, int novoTamanho)
        {
            Array.Resize(ref array,novoTamanho);
        }
        public int ObterIndice(int [] array, int valor)
        {
            //quando não encontrado na pesquisa o valor retornado é zero quando FIND
            return Array.FindIndex(array,elemento => elemento == valor);
        }
        public int ObterValor(int [] array,int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }
        public bool TodosMaiorQue(int [] array,int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }
        

        public bool Existe(int [] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }
        public void Copiar(ref int [] array, ref int [] ArrayDestino)
        {
            Array.Copy(array,ArrayDestino,array.Length);
        }
        //ordernar classe array
        public void Ordernar(ref int[] array)
        {
            Array.Sort(array);
        }
        //ref é para pegar a referencia de array ja criado
        public void OrdenarArray(ref int[] array)
        {
            int temp = 0;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }


    }
}