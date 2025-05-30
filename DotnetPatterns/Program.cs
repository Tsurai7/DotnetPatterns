using DotnetPatterns.Creational.Builder;

var builder = new ServerBuilder();

builder
    .SetCPU("Intel core i7")
    .SetRAM(256)
    .SetOS("Ubuntu")
    .SetStorage(1024)
    .SetSSD(true)
    .Build();