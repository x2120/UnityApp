#pragma strict

var shot : GameObject;
var shotSpawn : Transform;
var perBeat : float;

var BPM = 0;

function Start()
{
	perBeat = 1/perBeat;
	var fireRate : float = BPM/60;
	InvokeRepeating("shotsFired", 0, perBeat/fireRate);
}

function Update()
{

}

function shotsFired()
{
	Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
}