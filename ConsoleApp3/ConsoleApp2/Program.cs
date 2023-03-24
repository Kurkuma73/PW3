namespace PW3
{
    class SQLCommand
    {
        private string commandText;
        public SQLCommand(string commantText)
        {
            this.commandText = commantText;
            SQLToUpper();
        }

        public void SQLToUpper()
        {
            string[] SQLCommand = commandText.Split(' ');
            for (int i = 0; i < SQLCommand.Length; i++)
            {
                if (SQLCommand[i] == "insert" || SQLCommand[i] == "into" || SQLCommand[i] == "values")
                {
                    SQLCommand[i] = SQLCommand[i].ToUpper();
                }
            }
            string output = string.Join(" ", SQLCommand);
            Console.WriteLine(output);

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                SQLCommand newSQLCommand = new SQLCommand("insert into orders (id_clothing , type_clothing, time_notes, unit_value) values (1, 'Халат', '2 года', 2000)");// Запрос
            }
        }
    }
}