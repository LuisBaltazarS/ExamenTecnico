import { headers } from "next/headers";
import { TipoEventoModel } from "../models/TipoEventoModel";
import fetch from "node-fetch";

const url = "https://localhost:7019/api/";

export const getTipoEvento = async () =>  {
    

    try {

        const res = await fetch(url + "TipoEvento");

        const tipoEvento = await res.json();

        return { tipoEvento };

    }catch (error) {
        console.error("Error", error);
        throw error;
    }
    

}

