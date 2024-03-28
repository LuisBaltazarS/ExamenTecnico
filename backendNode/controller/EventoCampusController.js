import EventoCampusModel from "../models/EventoCampusModel";

async function isertEventoCampus(req, res) {

    try{

        const { EventoId, CampusId } = req.body;
        const newData = await EventoCampusModel.create({ EventoId, CampusId });

        res.status(201).json({
            message: 'Evento Campus registrado correctamente',
            data: newData
        });

    } catch (error) {

        console.error('Error al insertar el nuevo evento campus: ', error);
        res.status(500).json({ error: 'Error interno del servidor' });

    }
    
}

export {
    isertEventoCampus
};