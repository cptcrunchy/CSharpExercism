using System;

public class SpaceAge
{
	
	private readonly long earthYear = 31557600;
	public long Age { get; set; }
	public SpaceAge (long seconds) => Age = seconds;
	
	// - Earth: orbital period 31557600 seconds
    public double OnEarth() => (double)Age / earthYear;
	
    // - Mercury: orbital period 0.2408467 Earth years
	public double OnMercury() => (double)Age / (earthYear*0.2408467);
	
    //- Venus: orbital period 0.61519726 Earth years
	public double OnVenus() => (double)Age / (earthYear*0.61519726);
	
    //- Mars: orbital period 1.8808158 Earth years
	public double OnMars() => (double)Age / (earthYear*1.8808158);

    // - Jupiter: orbital period 11.862615 Earth years
	public double OnJupiter() => (double)Age / (earthYear*11.862615);
	
    //- Saturn: orbital period 29.447498 Earth years
	public double OnSaturn() => (double)Age / (earthYear*29.447498);

    // - Uranus: orbital period 84.016846 Earth years
	public double OnUranus() => (double)Age / (earthYear*84.016846);
	
    // - Neptune: orbital period 164.79132 Earth years
	public double OnNeptune() => (double)Age / (earthYear*164.79132);

}