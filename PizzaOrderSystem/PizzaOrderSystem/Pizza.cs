namespace PizzaOrderSystem
{
    internal class Pizza
    {
        public static string encodeOrder(string encoded)
        {
            //Get a string of character pairs
            //Return a string of pizzas
            string[] decoded = new string[encoded.Length / 2];
            string foo = "";
            for (int i = 0; i < encoded.Length; i += 2)
            {
                //Size: encoded[i]
                //Type: encoded[i+1]

                switch (encoded[i])
                {
                    case '1':
                        foo += "s";
                        break;
                    case '2':
                        foo += "m";
                        break;
                    case '3':
                        foo += "l";
                        break;
                }
                switch (encoded[i + 1])
                {
                    case '1':
                        foo += "c";
                        break;
                    case '2':
                        foo += "s";
                        break;
                    case '3':
                        foo += "p";
                        break;
                }
            }
            return foo;
        }

        public static string[] decodeOrder(string encoded)
        {
            //Get a string of character pairs
            //Return a string of pizzas
            string[] decoded = new string[encoded.Length / 2];

            for (int i = 0; i < encoded.Length; i += 2)
            {
                //Size: encoded[i]
                //Type: encoded[i+1]
                string foo = "";

                switch (encoded[i])
                {
                    case 's':
                        foo += "Small ";
                        break;
                    case 'm':
                        foo += "Medium ";
                        break;
                    case 'l':
                        foo += "Large ";
                        break;
                }
                switch (encoded[i + 1])
                {
                    case 'c':
                        foo += "Cheese";
                        break;
                    case 's':
                        foo += "Sausage";
                        break;
                    case 'p':
                        foo += "Pepperoni";
                        break;
                }
                foo += " Pizza";
                decoded[i / 2] = foo;

            }

            return decoded;
        }
    }
}
