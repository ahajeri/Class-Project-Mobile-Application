using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class ReplyPage : ContentPage
    {
        ReplyManager manager;
        object temp;
        public ReplyPage(object selectedItem)
        {
            temp = selectedItem;
            InitializeComponent();

            manager = ReplyManager.DefaultManager;

            if (selectedItem is string)
            {
                reply.Text = selectedItem as string;
            }
            else if (selectedItem is TodoItem)
            {
                reply.Text = (selectedItem as TodoItem).Name;
            }

            retrieve();
        }

        private async void retrieve()
        {
            replyList.ItemsSource = await manager.GetReplyAsync(temp);
        }

        async Task AddItem(ReplyMsg item)
        {
            await manager.SaveTaskAsync(item);
            replyList.ItemsSource = await manager.GetReplyAsync(temp);
        }
        public async void OnComplete(object sender, EventArgs e)
        {
            ReplyMsg item = new ReplyMsg
            {
                IdQ = (temp as TodoItem).Id,
                ReplyPost = replyEntry.Text,
                //Comment = "yes it is",
                Done = false
            };
            await AddItem(item);
            replyEntry.Text = "";
            // await App.MobileService.GetTable<ReplyMsg>().InsertAsync(item);
        }
    }
}
