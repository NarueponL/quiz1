using System;

public class FlowerInformation
{
	public string plantId;
	public string plantName;
	public string plantDescription;
	public int amount;
	public string height;
	public string circumference;

	public FlowerInformation(string plantId ,string plantName,string plantDescription,int amount ,string height,string circumference)
	{
		this.plantId = plantId;
		this.plantName = plantName;
		this.plantDescription = plantDescription;
		this.amount = amount;
		this.height = height;
		this.circumference = circumference;
	}
}
