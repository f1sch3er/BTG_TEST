// Implemente uma funcao que verifique se uma string contendo parenteses (), colchetes[] e chaves {} esta corretamente balanceada.

/* Premissas para validade do balanceamento:
-Toda abertura possui um fechamento correspondente.
- O fechamento ocorre na ordem correta.
- Nao existem fechamentos sem abertura previa.
 
Exemplos de entrada
 
( [ { } ] ) -> TRUE
([] { } ) -> TRUE
([ ) } -> FALSE
{ [ () ( ) ] } -> TRUE
{ [ ( ] } ) -> FALSE
*/

// separar em uma função

bool CheckPar(string value)
{
    List<char> output = new List<char>();

    // remoção de foreach redundante
    

    for (int i = 0; i < value.Length; i++)
    {
        char position = value[i];
        Console.WriteLine(position);

        if (position != '(' && position != ')' && 
            position != '[' && position != ']' && 
            position != '{' && position != '}')
        {
            //Console.WriteLine("A string não contém nenhum valor válido");
            return false;
        }

        if (position == '(' || position == '[' || position == '{')
        {
            output.Add(position);
            //adicionado ao array as primeiras partes
        }
        else
        {
            // se nada for adicionado, e porque a string veio com caractere errado
            if(output.Count <= 0)
            {
                return false;
            }

            char last_value = output[output.Count - 1];
            output.RemoveAt(output.Count - 1);

            if (position == ')' && last_value != '(') return false;
            if (position == ']' && last_value != '[') return false;
            if (position == '}' && last_value != '{') return false;
        }
    }
    return output.Count == 0;
}




string value = "([{}])";
Console.WriteLine(CheckPar(value));



