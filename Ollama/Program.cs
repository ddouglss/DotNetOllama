using OllamaSharp;

var url = new Uri("http://localhost:11434");
var client = new OllamaApiClient(url);


var models = await client.ListLocalModelsAsync();

client.SelectedModel = "phi3";


var chat = new Chat(client);
var prompt = Console.ReadLine() ?? string.Empty;

await foreach (var answer in chat.SendAsync(prompt))
    Console.Write(answer);


Console.WriteLine();
Console.WriteLine("---");
