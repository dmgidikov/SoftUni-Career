namespace _03.Telephony.Contracts
{
    interface ISmartphone
    {
        string Call(string number);

        string Browse(string site);
    }
}