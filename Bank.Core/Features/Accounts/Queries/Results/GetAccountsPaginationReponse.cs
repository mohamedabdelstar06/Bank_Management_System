﻿namespace Bank.Core.Features.Accounts.Queries.Results
{
    public class GetAccountsPaginationReponse : GetAccountByNameResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
