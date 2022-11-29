import React, { useEffect, useState } from 'react';
import axios from 'axios';
import './HomeContactView.css'
// import FormComponent from '../../components/FormComponent/FormComponent';

const HomeContactView = () => {

    const __baseUrl = "http://localhost:7777";
    const [contacts, setContacts] = useState([]);

    //    const [id, setId] = useState(''); 
    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');
    const [title, setTitle] = useState('');

    useEffect(() => {
        const fetchCours = () => {
            axios.get(__baseUrl + "/api/contacts")
                .then(res => {
                    if (res.status === 200) {
                        alert(res.data.message);
                        // console.log(res.data.data);

                        setContacts(res.data.data);
                    }
                })
                .catch(err => {
                    alert(err);
                })
        }
        fetchCours();
    }, [])

    ///////////////////////UPDATE CONTACT//////////////////

    async function updateContact(contact, id) {

        // Declaration d'un FormData (pour le body de la request)
        let bodyFormData = new FormData();
        // Ajout des elements au formulaire
        bodyFormData.append('Key', 'Value')
        bodyFormData.append('id', id);
        //bodyFormData.append('title', 'Mr');
        bodyFormData.append('firstname', prenom);
        bodyFormData.append('lastname', nom);
        bodyFormData.append('dateOfBirth', '1900-06-06');
        // bodyFormData.append('urlImg', ' ');
        bodyFormData.append('phone', telephone);
        bodyFormData.append('email', email);

        await axios({
            method: "put",
            url: __baseUrl + "/api/contact/" + id,
            data: bodyFormData,
            headers: {
                "Content-Type": "application/json"

            }
        }).then((res) => {
            if (res.status === 200) {
                alert(res.data.message)
            }
        }).catch(err => {
            alert(err);
            console.log(err)
        })

    }
    ///////************** */ END-UPDATE CONTACT/ **************/////////////////

    ///////////////////////ADD CONTACT//////////////////
    async function addContact(contact) {

        // Declaration d'un FormData (pour le body de la request)
        let bodyFormData = new FormData();
        // Ajout des elements au formulaire
        //bodyFormData.append('Key','Value')
        bodyFormData.append('id', 6);
        bodyFormData.append('title', title);
        bodyFormData.append('firstname', prenom);
        bodyFormData.append('lastname', nom);
        bodyFormData.append('dateOfBirth', '1900-06-06');
        // bodyFormData.append('urlImg', ' ');
        bodyFormData.append('phone', telephone);
        bodyFormData.append('email', email);

        await axios({
            method: "post",
            url: __baseUrl + "/api/contact",
            data: bodyFormData,
            headers: {
                "Content-Type": "application/json",
                "Access-Control-Allow-Origin": "*"
            }
        }).then((res) => {
            if (res.status === 200) {
                alert(res.data.message)
            }
        }).catch(err => {
            alert(err);
            console.log(err)
        })

    }
    ///////************** */ END-ADD CONTACT/ **************/////////////////

    //////////////////////////////DELETE CONTACT ////////////////////////////

    async function deleteContact(id) {


        await axios({
            method: "delete",
            url: __baseUrl + "/api/contact/" + 6,
            headers: {
                "Content-Type": "application/json"
            }
        }).then((res) => {
            if (res.status === 200) {
                alert(res.data.message)
            }
        }).catch(err => {
            alert(err);
            console.log(err)
        })

    }
    ////////////////////////////// END-DELETE CONTACT//////////////////////////


    return (
        <div className='container'>
            <h1>Contact List</h1>
            <table className="table table-dark">
                <thead>
                    <tr>
                        <th scope='col'>id</th>
                        <th scope='col'>Title</th>
                        <th scope='col'>Nom</th>
                        <th scope='col'>Prenom</th>
                        <th scope='col'>Email</th>
                        <th scope='col'>Date naissance</th>
                        <th scope='col'>Telephone</th>
                    </tr>
                </thead>
                {
                    contacts.map((person, index) => (
                        <tbody key={index}>
                            <tr>
                                <th scope='row'>{index + 1}</th>
                                <td>{person.title}</td>
                                <td>{person.lastname}</td>
                                <td>{person.firstname}</td>
                                <td>{person.email}</td>
                                <td>{person.dateOfBirth}</td>
                                <td>{person.phone}</td>
                            </tr>
                        </tbody>
                    ))
                }
            </table>
            {/* <FormComponent contacts={contacts} addContact={addContact} /> */}


            <div className="card">
                <form>
                    <div className="form-control formulaire">
                        <div className="mb-2">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name="nom" id="nom" onChange={(e) => setNom(e.target.value)} className="form-control" value={nom} />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name="prenom" id="prenom" onChange={(e) => setPrenom(e.target.value)} className="form-control" value={prenom} />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="email">Email : </label>
                            <input type="email" name="email" id="email" onChange={(e) => setEmail(e.target.value)} className="form-control" value={email} />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="telephone">Téléphone : </label>
                            <input type="text" name="telephone" id="telephone" onChange={(e) => setTelephone(e.target.value)} className="form-control" value={telephone} />
                        </div>
                        <select class="form-select" aria-label="Default select example">

                            <option selected value="1" onChange={(e) => setTitle(e.target.value)}>Mme </option>
                            <option value="2"  onChange={(e) => setTitle(e.target.value)}>Mr</option>     

                        </select>
                        <button onClick={() => addContact()} type="button" className="btn btn-success">Add Contact</button>
                    </div>
                </form>
            </div>




            <div className='container'>
                <h2>Actions :</h2>
                {/* <button onClick={() => addContact(nom, prenom, email, telephone)} type="button" className="btn btn-success">Add Contact</button> */}

                <button onClick={() => updateContact()} type="button" className="btn btn-primary">update Contact </button>
                <button onClick={() => deleteContact()} type="button" className="btn btn-danger">delete Contact </button>
            </div>
        </div>
    );
}

export default HomeContactView;
