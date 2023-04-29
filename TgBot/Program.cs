using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

TelegramBotClient client = new TelegramBotClient("5982116056:AAGkxgv_l_vEoDxhb5urQSRZkDFqF5MECl8");

User user = await client.GetMeAsync();

Console.WriteLine(user.Username);

while (true)
{
    Update[] updates = await client.GetUpdatesAsync();

    for (int i = 0; i < updates.Length; i++)
    {
        Console.WriteLine(updates[i].Message.Text);
        Console.WriteLine(updates[i].Message.From.FirstName);

        await client.SendTextMessageAsync(updates[i].Message.From.Id, "test text");
    }

    if (updates.Length != 0)
    {
        updates = await client.GetUpdatesAsync(updates[updates.Length - 1].Id + 1);
    }
}
