namespace Hell_Island_Fell.Custom_Stuff
{
    public class CustomIntents
    {
        public static void Add()
        {
            LoadedDBsHandler.IntentDB.m_IntentDamagePool.TryGetValue("Damage_1_2", out IntentInfoDamage intentInfoDamage);

            IntentInfoDamage Damage_Unbounded = new()
            {
                _color = intentInfoDamage._color,
                _enemyColor = intentInfoDamage._enemyColor,
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

            IntentInfoBasic AltAttacksIntent = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("PassiveAltAttacks"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_AltAttacks", AltAttacksIntent);

            IntentInfoBasic RemAltAttacksIntent = new()
            {
                _color = Color.grey,
                _sprite = ResourceLoader.LoadSprite("PassiveAltAttacks"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_AltAttacks", RemAltAttacksIntent);

            IntentInfoBasic InterpolatedIntent = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("ExambryInterpolated"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Interpolated", InterpolatedIntent);

            IntentInfoBasic RemInterpolatedIntent = new()
            {
                _color = Color.grey,
                _sprite = ResourceLoader.LoadSprite("ExambryInterpolated"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Interpolated", RemInterpolatedIntent);

            IntentInfoBasic WartsIntent = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("PassiveWarts"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Warts", WartsIntent);

            IntentInfoBasic RemWartsIntent = new()
            {
                _color = Color.grey,
                _sprite = ResourceLoader.LoadSprite("PassiveWarts"),
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Warts", RemWartsIntent);

            IntentInfoBasic ObscureIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Obscure.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Obscure", ObscureIntent);

            IntentInfoBasic RemObscureIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Obscure.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Obscure", RemObscureIntent);

            IntentInfoBasic RemFormlessIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Formless.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Formless", RemFormlessIntent);

            IntentInfoBasic RemForgetfulIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Forgetful.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Forgetful", RemForgetfulIntent);

            IntentInfoBasic RemAnchoredIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Anchored.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Anchored", RemAnchoredIntent);

            IntentInfoBasic RemSlipperyIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Slippery.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Slippery", RemSlipperyIntent);
        }
    }
}
