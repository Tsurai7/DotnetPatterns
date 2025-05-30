namespace DotnetPatterns.Creational.Builder;

public class Server
{
    public string CPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
    public string OS { get; set; }
    public bool HasSSD { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"Server configuration:\nCPU: {CPU}\nRAM: {RAM}GB\nStorage: {Storage}GB\nOS: {OS}\nSSD: {HasSSD}");
    }
}