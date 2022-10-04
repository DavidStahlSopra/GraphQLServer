﻿namespace GraphQLServer.Model.Entities;
public record struct Rating
{
    public int Number { get; init; }
    public double Score { get; init; }
}
