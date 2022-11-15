﻿using RestSharp;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");

RestRequest request = new("pokemon/snorlax");

RestResponse response = pokeClient.GetAsync(request).Result;

Console.WriteLine(response.StatusCode);

Console.ReadLine();