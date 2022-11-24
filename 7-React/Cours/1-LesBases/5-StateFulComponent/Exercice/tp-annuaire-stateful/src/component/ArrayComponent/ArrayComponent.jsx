import React, { Component } from 'react';
import './ArrayComponent.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faTrash, faPenToSquare } from '@fortawesome/free-solid-svg-icons'
import { NavLink } from 'react-router-dom';




class ArrayComponent extends Component {
    constructor(props) {
        super(props);
       // console.table(props.personList)
        this.state = {

        }
    }



    render() {
        return (
            <div>

            <table className="table table-striped">
                <thead>
                    <tr>
                        <th scope='col'>#</th>
                        <th scope='col'>Nom</th>
                        <th scope='col'>Prénom</th>
                        <th scope='col'>Email</th>
                        <th scope='col'>Téléphone</th>
                        <th scope='col'>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        this.props.personList.map((person, index) => (
                            <React.Fragment key={index}>
                                <tr >
                                    <th scope='col'>{index + 1}</th>
                                    <td>{person.nom}</td>
                                    <td>{person.prenom}</td>
                                    <td>{person.email}</td>
                                    <td>{person.telephone}</td>
                                    <td>
                                        <NavLink to={"/form/" + index}>
                                            <FontAwesomeIcon icon={faPenToSquare} className='fontIcon'/>
                                        </NavLink>
                                        {/* <FontAwesomeIcon icon={faTrash} onClick={() => deletePerson(index)}  className='fontIcon'/> */}
                                    </td>
                                </tr>
                            </React.Fragment>
                        ))
                    }
                </tbody>
            </table >

        </div >
        );
    }
}

export default ArrayComponent;
















// const ArrayComponent = ({ personList, updatePersonList, deletePerson }) => {
//     return (
//         <div>

//             <table className="table table-striped">
//                 <thead>
//                     <tr>
//                         <th scope='col'>#</th>
//                         <th scope='col'>Nom</th>
//                         <th scope='col'>Prénom</th>
//                         <th scope='col'>Email</th>
//                         <th scope='col'>Téléphone</th>
//                         <th scope='col'>Actions</th>
//                     </tr>
//                 </thead>
//                 <tbody>
//                     {
//                         personList.map((person, index) => (
//                             <React.Fragment key={index}>
//                                 <tr >
//                                     <th scope='col'>{index + 1}</th>
//                                     <td>{person.nom}</td>
//                                     <td>{person.prenom}</td>
//                                     <td>{person.email}</td>
//                                     <td>{person.telephone}</td>
//                                     <td>
//                                         <NavLink to={"/form/" + index}>
//                                             <FontAwesomeIcon icon={faPenToSquare} className='fontIcon'/>
//                                         </NavLink>
//                                         <FontAwesomeIcon icon={faTrash} onClick={() => deletePerson(index)}  className='fontIcon'/>
//                                     </td>
//                                 </tr>
//                             </React.Fragment>
//                         ))
//                     }
//                 </tbody>
//             </table >

//         </div >
//     );
// }

// export default ArrayComponent;
