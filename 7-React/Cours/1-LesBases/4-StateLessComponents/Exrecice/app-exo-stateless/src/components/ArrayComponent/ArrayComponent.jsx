import React from 'react';
import './ArrayComponent.css';


const ArrayComponent = ({contactList,setcontactList}) => {

    return (
        
        <div>

            <table className="table table-dark">
                <thead>
                    <tr>
                        <th scope="col">Nom</th>
                        <th scope="col">Prenom</th>
                        <th scope="col">Email</th>
                        <th scope="col">Telephone</th>
                    </tr>
                </thead>
                {contactList.map((contact, index) =>               
                    <tbody key={index}>             
                        <tr>
                            <td > {contact.nom}</td>
                            <td>{contact.prenom}</td>
                            <td>{contact.email}</td>
                            <td>{contact.telephone}</td>
                        </tr>
                    </tbody>
                )}

            </table>

        </div>
    );

}

export default ArrayComponent;