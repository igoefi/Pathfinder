using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfTest2012.Game;
using WpfTest2012.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WpfTest2012.HelperClasses
{
    internal abstract class SaveCotroller
    {
        public static void SaveGameInUser(GameArraysJson file, User user)
        {
            IEnumerable<User> users = DataBaseConnectContext.ConnectContext.User.Where(c => c.Id == user.Id).
                    AsEnumerable().Select(
                    c =>
                    {
                        c.LastGame = JsonConvert.SerializeObject(file);
                        return c;
                    });
            foreach (var needUser in users)
                DataBaseConnectContext.ConnectContext.Entry(user).State = EntityState.Modified;

            DataBaseConnectContext.ConnectContext.SaveChanges();
        }
    }
}
