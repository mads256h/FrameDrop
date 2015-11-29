var smooth = 5.0;
function Update(){

    var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    var hit : RaycastHit;
    if(Physics.Raycast(ray,hit,50)){
        if(hit.transform.gameObject.tag == "cursorFollow"){
            Drag(hit);

        }
    }
}
function Drag(_h : RaycastHit){
    transform.position = Vector3.Lerp (
    transform.position, _h.point,
    Time.deltaTime * smooth);
} 