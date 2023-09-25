using System.Text;

var millisDelay = 10000;
var url = "https://api.live-spreadsheet.atras.my.id/users";

async Task runRequest()
{
    while (true)
    {
        Console.WriteLine($"Helloworld {DateTime.Now}");

        try
        {
            var resp = await new HttpClient().PostAsync(
                url,
                new StringContent("{}", Encoding.UTF8, "application/json")
            );
            Console.WriteLine(await resp.Content.ReadAsStringAsync());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        await Task.Delay(millisDelay);
    }
}

await Task.Run(runRequest);