import React, { Component } from 'react';
import ArrayComponent from '../../component/ArrayComponent/ArrayComponent';
import './ListPersonView.css'


class ListPersonView extends Component {
    constructor(props) {
        super(props);
       // console.table(props.personList)
        this.state = {

        }

        this.addPersonList = (list,nom,prenom,listTmp,telephone,email,newPerson) =>{
            this.setState({

                personList :list,
                newPerson : {nom, prenom, email, telephone},
                listTmp : [...list],
                
            })
            listTmp.push(newPerson)
            
        }
            // function AddPerson(nom, prenom, email, telephone) {
    //     //alert(`${nom} ${prenom} ${email} ${telephone}`);
    //     let newPerson = { nom, prenom, email, telephone };
    //     console.log(newPerson);
    //     let listTmp = [...personList];
    //     console.table(listTmp);
    //     listTmp.push(newPerson)
    //     console.table(listTmp);
    //     updatePersonList(listTmp);
    //     //updatePersonList([...personList, { nom, prenom, email, telephone }])
    //     alert(`${nom} ${prenom} a été ajouté`);
    //     console.table(personList);
    // }


    }
    render() {
        return (
            <div>
                <h1>ListPersonView</h1>
                {console.table(this.props.personList)}
                <ArrayComponent  personList={this.props.personList} updatePersonList={this.props.updatePersonList}/>
            </div>
        );
    }
}

export default ListPersonView;


// const ListPersonView = ({personList,updatePersonList}) => {


//     /**
//      * FUNCTION()
//      */
//     function deletePerson(tabIndex){
//         if(window.confirm(`Etes-vous sur de vouloir supprimer la personne n°${tabIndex+1}`)){
//             let newList = personList.filter((person,index)=> index !==tabIndex);
//             console.log(newList)
//             updatePersonList(newList);
//             alert(`Le contact n0${tabIndex+1} a été supprimé!`);
//         }
//     }

//     return (
//         <div className='container'>
//             <h1 className='title'>Liste de contact</h1>
//             <ArrayComponent personList={personList} updatePersonList={updatePersonList} deletePerson={deletePerson} />
//         </div>
//     );
// }

// export default ListPersonView;
