



//var rend=GetComponent.<Renderer>();

function Start () {
//rend.enable=true;
}

function Update () {
timeWentY += Time.deltaTime*speedY;
timeWentX += Time.deltaTime*speedX;

rend=GetComponent.<Renderer>();

rend.materials[targetMaterialSlot].SetTextureOffset ("_MainTex", Vector2(timeWentX, timeWentY));


}

function OnEnable(){
rend=GetComponent.<Renderer>();

	rend.materials[targetMaterialSlot].SetTextureOffset ("_MainTex", Vector2(0, 0));
	timeWentX = 0;
	timeWentY = 0;
}