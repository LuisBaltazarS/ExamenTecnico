
import { Divider, Input, Select, SelectSection, SelectItem } from "@nextui-org/react";
import { TipoEventoModel } from "../models/TipoEventoModel";

export default function Form( { data }: { data:any } ) {

    const tipo = data.tipoEvento || [];
    console.log(tipo);

    return (

        <form>

            {
                    data.tipoEvento.map(( elemento: TipoEventoModel ) => (

                        <h1>{ elemento.name }</h1>
                        
                    ))
                }
            <h1>CREAR EVENTO</h1>
            
            <Input type="text" maxLength={100} label="Nombre del Evento" labelPlacement="outside-left" variant="bordered" radius="none"></Input>

            <Input type="text" maxLength={400} label="Descripción del Evento" labelPlacement="outside-left" variant="bordered" radius="none"></Input>z

            <Select label="Tipo de Evento">
                {
                    tipo.map( (option: TipoEventoModel, index: number) => (
                        <SelectItem key={option.name} value={option.id} >{option.name}</SelectItem>
                    ))
                }
            </Select>

        </form>

    );

    

}