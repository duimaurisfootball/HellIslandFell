namespace Hell_Island_Fell.Custom_Stuff
{
    public class CustomIntents
    {
        public static void Add()
        {
            IntentInfoDamage Damage_Unbounded = new()
            {
                _color = Color.magenta,
                _enemyColor = Color.red,
                _sprite = ResourceLoader.LoadSprite("IntentUnboundDamage"),
                _enemySprite = ResourceLoader.LoadSprite("IntentUnboundDamage"),
            };
            LoadedDBsHandler.IntentDB.AddNewDamageIntent("Damage_Unbounded", Damage_Unbounded);

            IntentInfoBasic Heal_Unbounded = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("IntentUnboundHeal"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Heal_Unbounded", Heal_Unbounded);

            IntentInfoBasic CostRerollIntent = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("IntentCostReroll")
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Reroll_Cost", CostRerollIntent);

            IntentInfoBasic CostModifyIntent = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("IntentCostModify")
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Modify_Cost", CostModifyIntent);

            IntentInfoBasic ObscureIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Obscure.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Obscure", ObscureIntent);

            IntentInfoBasic RemAnchoredIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Anchored.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Anchored", RemAnchoredIntent);

            IntentInfoBasic RemInfantileIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Infantile.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Infantile", RemInfantileIntent);

            IntentInfoBasic RemObscureIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Obscure.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Obscure", RemObscureIntent);

            IntentInfoBasic RemImmortalIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Immortal.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Immortal", RemImmortalIntent);

            IntentInfoBasic RemCatalystIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Catalyst.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Catalyst", RemCatalystIntent);

            IntentInfoBasic RemLeakyIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Leaky1.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Leaky", RemLeakyIntent);
        }
    }
}
