import CampusModel from "../models/CampusModel.js";

async function insertCampus(req, res) {

    try{

        const { Id, Name } = req.body;
        const newData = await CampusModel.create({ Id, Name });

        res.status(201).json({
            message: 'Campus registrado correctamente',
            data: newData
        });

    } catch (error) {

        console.error('Error al insertar el nuevo campus: ', error);
        res.status(500).json({ error: 'Error interno del servidor' });

    }
    
}

export {
    insertCampus
};