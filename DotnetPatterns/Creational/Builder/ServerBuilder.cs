namespace DotnetPatterns.Creational.Builder;

public class ServerBuilder
{
    private Server _server = new Server();
    
    public ServerBuilder SetCPU(string cpu)
    {
        _server.CPU = cpu;
        return this;
    }
    
    public ServerBuilder SetRAM(int ram)
    {
        _server.RAM = ram;
        return this;
    }
    
    public ServerBuilder SetStorage(int storage)
    {
        _server.Storage = storage;
        return this;
    }
    
    public ServerBuilder SetOS(string os)
    {
        _server.OS = os;
        return this;
    }
    
    public ServerBuilder SetSSD(bool hasSSD)
    {
        _server.HasSSD = hasSSD;
        return this;
    }
    
    public Server Build()
    {
        if(string.IsNullOrEmpty(_server.CPU))
            throw new InvalidOperationException("CPU must be set");
            
        return _server;
    }
}