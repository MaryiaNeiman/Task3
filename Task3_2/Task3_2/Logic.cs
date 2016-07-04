using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
   public class Logic
    {
        Input inputForName = new Input();
        Input inputForAge = new Input();
        Button button = new Button();


        public Page SaveNewUser(string userName, string userAge, Page page)
        {
            List<Element> list = new List<Element>();
            list = page.GetAllElement();

            foreach (var item in list)
            {
                if (inputForName.Name.Equals(item.Name))
                {
                    inputForName.Text = userName;
                }
                if (inputForAge.Name.Equals(item.Name))
                {
                    inputForAge.Text = userAge;
                }
            }
            if (button.Name == "Save")
            {
                button.Click();
            }

            return page.LoadPage();



        }
    }
}
