import EventoModel from "../models/EventoModel.js";

async function insertEvento(req, res) {

    try {

        const { Id, Name, Description, Capacity, StartDate, EndDate, TipoEventoId, SubtipoEventoId, OrganizadorId, DocenteId, UbicacionId } = req.body;

        const newData = await EventoModel.create({ Id, Name, Description, Capacity, StartDate, EndDate, TipoEventoId, SubtipoEventoId, OrganizadorId, DocenteId, UbicacionId });


        res.status(201).json({
            message: 'Campus registrado correctamente',
            data: newData
        });

    } catch (error) {

        console.error('Error al insertar el nuevo evento: ', error);
        res.status(500).json({ error: 'Error interno del servidor' });

    }

}

export {

    insertEvento
}