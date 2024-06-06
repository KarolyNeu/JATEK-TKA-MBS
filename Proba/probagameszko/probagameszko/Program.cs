class Leny {
    public string Nev { get; set; }
    public int Eletero { get; set; }
    public int Tamadas { get; set; }
    public int Vedekezes { get; set; }

    public Leny(string nev, int eletero, int tamadas, int vedekezes) {
        Nev = nev;
        Eletero = eletero;
        Tamadas = tamadas;
        Vedekezes = vedekezes;
    }

    public void Tamad(Leny celpont) {
        int sebesites = Tamadas - celpont.Vedekezes;
        if (sebesites > 0) {
            celpont.Eletero -= sebesites;
            Console.WriteLine($"{Nev} megtámadta {celpont.Nev}-et, és {sebesites} sebzést okozott.");
        } else {
            Console.WriteLine($"{Nev} támadása nem okozott sebzést {celpont.Nev}-nek.");
        }
    }

    public void Gyogyit() {
        // ... gyógyítási logika
    }
}

class Csatater {
    public List<Leny> Jatekosok { get; set; }
    public List<Leny> Ellensegek { get; set; }

    public Csatater(List<Leny> jatekosok, List<Leny> ellensegek) {
        Jatekosok = jatekosok;
        Ellensegek = ellensegek;
    }

    public void KezddElACsatat() {
        while (Jatekosok.Count > 0 && Ellensegek.Count > 0) {
            JatekosKoreo();
            EllensegKoreo();
        }

        if (Jatekosok.Count > 0) {
            Console.WriteLine("A játékosok győztek!");
        } else {
            Console.WriteLine("Az ellenségek győztek!");
        }
    }

    private void JatekosKoreo() {
        foreach (Leny jatekos in Jatekosok) {
            // ... játékos cselekvési logika
        }
    }

    private void EllensegKoreo() {
        foreach (Leny ellenseg in Ellensegek) {
            // ... ellenség cselekvési logika
        }
    }
}
