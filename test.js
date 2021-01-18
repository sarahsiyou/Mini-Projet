const device = {
   firmwareArray : [],
   declarerFirmware: function(c){
     if (this.firmware==undefined){
      this.firmware=c;
      this.firmwareArray.push(this.firmware);
      //console.log("ok")
     }else{
      console.log("ko firmware déja déclaré")
      }
    },
    declarerPatient: function(c){
    if (this.patient==undefined){
      this.patient=c;
      //console.log("ok")
    }else{
     console.log("ko : patient déja associé")
    }
  },
    dissociationPatient: function(c){
      if (this.patient==c){
        this.patient=undefined;
        //console.log("ok")
      }else{
       console.log("ko ils n'étaient pas associés")
      }
    },
    miseajourFirmware: function(c){
      this.firmware=c;
      this.firmwareArray.push(this.firmware);
      console.log("la liste des firmware du device :",this.firmwareArray);
    }

  };
//create a device
const slb1 = Object.create(device);
const slb2 = Object.create(device);
const slb3 = Object.create(device);

slb1.name='SLB-01';
slb1.firmware='FW-01';
slb1.patient='User-01';

slb2.name='SLB-02';

slb3.name='SLB-03';

//redéclaration du FW1 pour patint 1 :  ko firmware déja déclaré
console.log("redéclaration du FW1 pour patient 1 :")
slb1.declarerFirmware("FW1-01")

// déclaration du FW1 pour patient 2 :
slb2.declarerFirmware("FW-01")
console.log("déclaraion du device 2 avec le firmware 1 :", slb2)

// association du device 1  avec le patient 1 :  ko patient deja associé
console.log("association du device 1  du patient 2 :")
slb1.declarerPatient("User-02")

//associationdu device 2 avec un patient 2 :
slb2.declarerPatient("User-02")
console.log("association du device 2 avec un patient 2 :", slb2)

// dissociation du patient 3 avec le device 1 : ko ils n'étaient pas associés
console.log("dissociation du patient 3 avec le device 3 :")
slb3.dissociationPatient("User-03")

//dissosiation du patient 1 avec patient 1 :
slb1.dissociationPatient("User-01")
console.log("dissociation du patient 1 avec patient 1 :", slb1)

slb1.firmware='FW-01';
slb2.firmware='FW-02  ';
//mise aà jour du device 1 avec firmware 2 :
slb1.miseajourFirmware("FW-02")
console.log("mise à jour du firmware :", slb1)
