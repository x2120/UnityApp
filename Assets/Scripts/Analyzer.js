#pragma strict

var magnitude : float;
var seconds : float;

function Start () {
    var repeats : float = 1/seconds;
	InvokeRepeating("Analyse", 0, repeats);
}

function Update () {

}

function Analyse() {
	var spectrum : float[] = AudioListener.GetSpectrumData(1024, 0, FFTWindow.Hamming);
	/*
	c1 = 25hz
	c2 = 40hz
	c3 = 63hz
	c4 = 100hz
	c5 = 160hz
	c6 = 256hz
	c7 = 400hz
	c8 = 512hz
	c9 = 1024hz
	c10 = 1.6khz
	c11 = 2.5khz
	c12 = 4khz
	c13 = 6.3khz
	c14 = 10khz
	c15 = 16khz
	*/

	var c1 : float = spectrum[0] + spectrum[1] + spectrum[2];
	var c2 : float = spectrum[1] + spectrum[2] + spectrum[3];
	var c3 : float = spectrum[2] + spectrum[3] + spectrum[4];
	var c4 : float = spectrum[4] + spectrum[5] + spectrum[6];
	var c5 : float = spectrum[6] + spectrum[7] + spectrum[8];
	var c6 : float = spectrum[11] + spectrum[12] + spectrum[13];
	var c7 : float = spectrum[18] + spectrum[19] + spectrum[20];
	var c8 : float = spectrum[22] + spectrum[23] + spectrum[24];
	var c9 : float = spectrum[44] + spectrum[45] + spectrum[46] + spectrum[47] + spectrum[48] + spectrum[49];
	var c10 : float = spectrum[74] + spectrum[75] + spectrum[76] + spectrum[77] + spectrum[78] + spectrum[79];
	var c11 : float = spectrum[117] + spectrum[118] + spectrum[119] + spectrum[120] + spectrum[121] + spectrum[122];
	var c12 : float = spectrum[186] + spectrum[187] + spectrum[189] + spectrum[190] + spectrum[191] + spectrum[192];
	var c13 : float = spectrum[296] + spectrum[297] + spectrum[298] + spectrum[299] + spectrum[300] + spectrum[301] + spectrum[302] + spectrum[303] + spectrum[304];
	var c14 : float = spectrum[472] + spectrum[473] + spectrum[474] + spectrum[475] + spectrum[476] + spectrum[477] + spectrum[478] + spectrum[479] + spectrum[480];
	var c15 : float = spectrum[722] + spectrum[723] + spectrum[724] + spectrum[725] + spectrum[726] + spectrum[727] + spectrum[728] + spectrum[729] + spectrum[730] + spectrum[731] + spectrum[732] + spectrum[733] + spectrum[734] + spectrum[735] + spectrum[736];

	var cubes : GameObject[] = GameObject.FindGameObjectsWithTag("Cubes");
	for(var i = 0; i < cubes.length; i++) {
		switch (cubes[i].name) {
			case "c1": cubes[i].transform.localScale.x = c1 * (magnitude/4); break;
			case "c2": cubes[i].transform.localScale.x = c2 * (magnitude/4); break;
			case "c3": cubes[i].transform.localScale.x = c3 * (magnitude/4); break;
			case "c4": cubes[i].transform.localScale.x = c4 * (magnitude/2); break;
			case "c5": cubes[i].transform.localScale.x = c5 * (magnitude/2); break;
			case "c6": cubes[i].transform.localScale.x = c6 * (magnitude/2); break;
			case "c7": cubes[i].transform.localScale.x = c7 * magnitude; break;
			case "c8": cubes[i].transform.localScale.x = c8 * magnitude; break;
			case "c9": cubes[i].transform.localScale.x = c9 * magnitude; break;
			case "c10": cubes[i].transform.localScale.x = c10 * (magnitude * 2); break;
			case "c11": cubes[i].transform.localScale.x = c11 * (magnitude * 2); break;
			case "c12": cubes[i].transform.localScale.x = c12 * (magnitude * 2); break;
			case "c13": cubes[i].transform.localScale.x = c13 * (magnitude * 4); break;
			case "c14": cubes[i].transform.localScale.x = c14 * (magnitude * 4); break;
			case "c15": cubes[i].transform.localScale.x = c15 * (magnitude * 4); break;
		}
	}

}