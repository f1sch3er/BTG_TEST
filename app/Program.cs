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

    // evitar de ter que validar possíveis valores diferentes do objetivo
    foreach (char c in value)
    {
        if (!"()[]{}".Contains(c))
            break;
    }

    for (int i = 0; i < value.Length; i++)
    {
        char position = value[i];
        Console.WriteLine(position);

        if (position != '(' && position != ')' && position != '[' && position != ']' && position != '{' && position != '}')
        {
            //Console.WriteLine("A string não contém nenhum valor válido");
            return false;
        }

        if (position == '(' || position == '[' || position == '{')
        {
            output.Add(position);
        }

        if (position != ')' || position != ']' || position != '}')
        {
            //Console.WriteLine(position);
            //Console.WriteLine(value[i]); 
            if(output.Count <= 0)
            {
                //Console.WriteLine(output);
                return false;
            }

            char last_value = output[output.Count - 1];
            output.RemoveAt(output.Count - 1);

            if (position == ')' && last_value != '(') return false;
            if (position == ']' && last_value != '[') return false;
            if (position == '}' && last_value != '{') return false;


        }

    }
    return true;
}




string value = "([{}])";
Console.WriteLine(CheckPar(value));



