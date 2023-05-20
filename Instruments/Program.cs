using Instruments;

Instrument firzamonike = new Instrument("firzamonike", false);
Clean(firzamonike);

Trumpet trumpet = new Trumpet("T", false, true);
bool isOiled = trumpet.Oiled;
Clean(trumpet);

void Clean (Instrument instrument)
{
    if (!instrument.Clean)
    {
        instrument.CleanInstrument();
    }
}