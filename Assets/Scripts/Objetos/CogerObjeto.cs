using UnityEngine;

public class CogerObjeto : Interactivo {

    public Objeto objeto;

    public override void Interactuar()
    {
        base.Interactuar();
        Coger();
    }

    void Coger()
    {
        Debug.Log("Adquieres " + objeto.name);
        Inventario.instance.Añadir(objeto);
        Destroy(gameObject);
    }

}
