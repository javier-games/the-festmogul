namespace BoardGame
{
    public class Marketing : Job
    {
        protected override int PlayersQuota => 
            GameDefinitions.MarketingPlayersQuota;
        protected override int PlacesQuota => 
            GameDefinitions.MarketingPlacesQuota;
        public override int PlacesPerPlayerQuota =>
            GameDefinitions.MarketingPlacesPerPlayerQuota;
        
        public override void Prepare() { }

        protected override bool CanExchangePerPlayer(Player player) => true;

        protected override void ExchangePerPlayer(Player player) { }
        
        protected override bool CanExchangePerWorker(Player player) => 
            player.Budget >= GameDefinitions.MarketingCost 
            && player.CanAcquireViews();

        protected override void ExchangePerWorker(Player player)
        {
            player.Pay(GameDefinitions.MarketingCost);
            player.AddViews(GameDefinitions.MarketingPayback);
        }
    }
}