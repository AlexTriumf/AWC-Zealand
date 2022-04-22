using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MandatoryAWC
{
    public class Commands
    {
        public string Command { get; set; }
        public string Description { get; set; }

        public List<Commands> vCommands = new List<Commands>();
        public Commands()
        {
            LoadCommands();
        }

        private void LoadCommands()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load("/Configs/Commands.config");

            try
            {
            dynamic json = JsonConvert.SerializeObject(configDoc);
                
                foreach (var command in json.Commands)
                {
                    vCommands.Add(new Commands
                    {
                        Command = command.ToString(),
                        Description = command.Description.ToString(),
                    });
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetCommand(string command)
        {
            return vCommands.Where(x => x.Command.Contains(command)).SingleOrDefault().Command;
        }

        public bool CommandValidation(string command)
        {
            return vCommands.Where((x) => x.Command.Contains(command)).SingleOrDefault() != null;
        }

        public void ShowCommands()
        {
            foreach (Commands words in vCommands)
            {
                
                    Console.WriteLine($"{words}");
                
            }

        }

        public void Show(string command)
        {
            var cmd = vCommands.Where(c => c.Command.Contains(command)).SingleOrDefault();
            if (command == null)
            {
                Console.WriteLine("Command does not exist");
            }
            Console.WriteLine($" {cmd.Command}");
            Console.WriteLine($" {cmd.Description}");
            
        }
    }
}
