// import React, { useState, useEffect } from 'react';

const FormComponent = (contacts,addContact) => {

// console.log(contacts.addContact);


//    const [nom, setNom] = useState('');
//    const [prenom, setPrenom] = useState('');
//    const [email, setEmail] = useState('');
//    const [telephone, setTelephone] = useState('');

    return (
        <div>
  {/* <div className="card">
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

  
                                
                                <button onClick={() => addContact(nom, prenom, email, telephone)} type="button" className="btn btn-success">Add Contact</button>
                 
                    </div>
                </form>
            </div> */}
        </div>
    );
}

export default FormComponent;
