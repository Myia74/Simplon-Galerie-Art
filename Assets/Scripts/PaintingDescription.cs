using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PaintingDescription : MonoBehaviour
{
    //optimisation de la collecte de donnees pour la prochaine fois passer par le lien internet des peintures 

    [SerializeField] private string[] artistName = { "L�onard de Vinci", "Vincent Van Gogh", "Edward Munch", "Claude Monet", "Diego Vel�zquez", "Frida Kahlo", "Rembrandt", "Gustav Klimt", "Alexandre Cabanel", "Pierre-Auguste Renoir", "Sandro Botticelli","" };   // nom artiste
    [SerializeField] private string[] artWorkName = { "La_Joconde_-_De_Vinci", "Van-Gogh.-La-nuit-etoilee", "le-cri-munch-1893", "Claude-Monet-Water-Lilies-or-Nympheas-", "Les_Mnines_Velasquez", "les_deux_fridas141870", "rembrandt-ronde-de-nuit", "Le_Baiser_-_Klimt", "Cabanel-Lange_dchu", "Pierre-Auguste_Renoir_-_Luncheon_of_the_Boating_Party_-_Google_Art_Project", "Sandro_Botticelli_-_La_nascita_di_Venere_-_Google_Art_Project_-_edited", "" }; // nom oeuvre (image)
    [SerializeField] private string[] description = { "La Joconde, �galement connue sous le nom de Mona Lisa, est une peinture � l'huile sur bois r�alis�e par L�onard de Vinci entre 1503 et 1506. Elle mesure 30 x 21 cm. Ce tableau est consid�r� comme l'un des chefs-d'�uvre de la peinture mondiale, et l'une des �uvres les plus c�l�bres de l'histoire de l'art. Il repr�sente une jeune femme souriante, assise devant un paysage en arri�re-plan. La Joconde est c�l�bre pour son sourire �nigmatique et son utilisation innovante de la lumi�re et de l'ombre pour cr�er de la profondeur. Depuis sa cr�ation, il a �t� expos� dans de nombreux mus�es � travers le monde, et il est actuellement expos� au mus�e du Louvre � Paris.", "La Nuit �toil�e de Van Gogh est une peinture � l'huile sur toile cr��e en 1888. Il repr�sente un paysage nocturne avec un ciel �toil�, des arbres et une route. Van Gogh a utilis� des couleurs vives et des traits de pinceau expressifs pour capturer l'�motion de cette sc�ne. Il a �t� peint pendant son s�jour � l'asile Saint-Paul-de-Mausole, � Saint-R�my-de-Provence. Cette peinture est consid�r�e comme l'un des chefs-d'�uvre de Van Gogh et de l'impressionnisme. Il a �t� r�alis� en seulement une nuit, lorsque Van Gogh a �t� inspir� par les �toiles et la tranquillit� de la nature qui l'entourait. Il a utilis� des couleurs vives pour repr�senter les �toiles et les arbres, cr�ant ainsi un contraste saisissant entre la lumi�re et l'obscurit�. Cette �uvre est consid�r�e comme l'une des plus c�l�bres de Van Gogh, et est souvent consid�r�e comme un symbole de la lutte de l'artiste pour se connecter � la nature.", "Le Cri de Munch est une peinture � l'huile sur toile cr��e en 1893. Il repr�sente un homme qui crie, entour� d'un paysage d�chirant et d'�l�ments symboliques tels que des mains qui se tendent vers lui. Munch a voulu exprimer l'angoisse et la solitude humaine � travers cette �uvre. Il a �t� peint pendant sa p�riode symboliste et est consid�r� comme l'un des chefs-d'�uvre de l'expressionnisme. Il est devenu un symbole de l'angoisse moderne dans l'art, et a �t� interpr�t� de diff�rentes mani�res, comme un cri de d�sespoir face � la vie moderne ou un reflet de la solitude de l'individu moderne. Les couleurs utilis�es sont sombres, refl�tant l'humeur d�pressives de l'artiste � cette �poque. Le cri est surtout un symbole de l'angoisse, de la solitude et de l'incapacit� � trouver sa place dans le monde.", "Les N�nuphars de Monet est une s�rie de peintures � l'huile sur toile cr��e en 1899. Il repr�sente des n�nuphars flottant sur une �tendue d'eau, avec un ciel nuageux en arri�re-plan. Monet a utilis� des couleurs vives et des touches de pinceau pour capturer la lumi�re changeante de cette sc�ne. Il a �t� peint pendant sa p�riode impressionniste et est consid�r� comme l'un des chefs-d'�uvre de Monet. Il a peint cette s�rie de tableaux en se concentrant sur les n�nuphars qui poussent dans son jardin d'eau � Giverny. Il a utilis� des couleurs vives pour repr�senter les n�nuphars, en utilisant des touches de pinceau pour cr�er un effet de mouvement et de profondeur. Il a �galement utilis� des couleurs pour capturer les variations de lumi�re et les reflets de l'eau. Les N�nuphars de Monet sont devenus l'un des symboles les plus connus de l'impressionnisme et de l'art moderne en g�n�ral.", "Les M�nines de Vel�zquez est une peinture � l'huile sur toile r�alis�e en 1656. Elle repr�sente la reine d'Espagne, Marie-Th�r�se, et ses dames d'honneur, avec Vel�zquez lui-m�me peint en train de peindre le tableau dans le coin en bas � droite. Cette �uvre est consid�r�e comme un des chefs-d'�uvre de la peinture espagnole, et l'une des �uvres les plus importantes de Vel�zquez. Il est reconnu pour son utilisation de la mise en sc�ne, de la lumi�re et de la perspective pour cr�er une image complexe et riche de sens. Il est expos� au Mus�e du Prado � Madrid.", "Les Deux Fridas de Frida Kahlo est une peinture � l'huile sur toile r�alis�e en 1939. Elle repr�sente deux versions de Frida Kahlo assises c�te � c�te, main dans la main, chacune v�tue de la tenue traditionnelle mexicaine. Le c�ur de l'une d'elles est ouvert et reli� par des veines � celui de l'autre. La peinture est consid�r�e comme l'une des �uvres les plus importantes de Frida Kahlo et refl�te sa propre exp�rience personnelle et ses �motions. Elle est vue comme un symbole de l'autor�flexion et de l'identit� personnelle. Elle est souvent interpr�t�e comme une repr�sentation de la dualit� de Frida Kahlo en tant qu'individu et de son identification comme une femme mexicaine. Les couleurs utilis�es sont vives, refl�tant l'�nergie de Frida Kahlo.", "La Ronde de Nuit de Rembrandt est une peinture � l'huile sur toile r�alis�e en 1642. Elle repr�sente une sc�ne de rue nocturne avec des personnages habill�s en costumes de l'�poque, dont un personnage principal qui tient une lanterne. La peinture est consid�r�e comme l'une des �uvres les plus importantes de Rembrandt et est reconnue pour son utilisation innovante de la lumi�re pour cr�er une atmosph�re dramatique et r�aliste. Le tableau est vu comme une repr�sentation de la vie quotidienne de l'�poque et de l'humanit� commune. Les couleurs utilis�es sont sombres, refl�tant l'ambiance nocturne de la sc�ne. La Ronde de Nuit de Rembrandt est souvent consid�r�e comme un chef-d'�uvre de l'utilisation de la lumi�re dans l'art et est expos�e dans les mus�es � travers le monde.", "Le Baiser de Klimt est une peinture � l'huile sur toile r�alis�e en 1908. Il repr�sente un couple en train de s'embrasser, entour� d'un d�cor luxuriant et de motifs ornementaux. La peinture est consid�r�e comme l'une des �uvres les plus importantes de Klimt et est reconnue pour son utilisation innovante de la couleur, de la forme et des motifs pour cr�er une image sensuelle et �rotique. Il est souvent consid�r� comme une repr�sentation de l'amour et de la passion. Il a �t� peint pendant sa p�riode Art nouveau, o� il a d�velopp� un style original, qui m�lange des �l�ments de l'art byzantin, des motifs traditionnels viennois et des influences japonisantes. Le Baiser de Klimt est souvent consid�r� comme un symbole de l'�mancipation des femmes et de la lib�ration sexuelle.", "L'Ange D�chu de Cabanel est une peinture � l'huile sur toile r�alis�e en 1863. Il repr�sente un ange d�chu, nu, entour� d'un d�cor romantique et dramatique. La peinture est consid�r�e comme l'une des �uvres les plus importantes de Cabanel et est reconnue pour son utilisation innovante de la couleur, de la forme et des motifs pour cr�er une image sensuelle et �rotique. Il est souvent consid�r� comme une repr�sentation de la chute de l'ange et de la perte de l'innocence. Il a �t� peint pendant une p�riode o� le romantisme �tait en vogue, et refl�te les th�mes romantiques tels que la nature, l'�motion et le mysticisme. L'Ange D�chu de Cabanel est souvent consid�r� comme un symbole de la condition humaine et de la prise de conscience de la faiblesse et de la vuln�rabilit�.", "Le D�jeuner des Canotiers de Renoir est une peinture � l'huile sur toile r�alis�e en 1881. Il repr�sente un groupe de personnes, principalement des femmes, dans un bateau � rames, en train de d�jeuner. La peinture est consid�r�e comme l'une des �uvres les plus importantes de Renoir et est reconnue pour son utilisation innovante de la couleur, de la forme et des motifs pour cr�er une image joyeuse et ensoleill�e. Il a �t� peint pendant sa p�riode impressionniste, o� il a d�velopp� un style original, qui m�lange des �l�ments de l'art traditionnel et des influences modernes. Il a utilis� des couleurs vives pour repr�senter les personnages et les paysages, cr�ant ainsi un contraste saisissant entre la lumi�re et l'ombre. Le D�jeuner des Canotiers de Renoir est souvent consid�r� comme un symbole de la vie joyeuse et de l'insouciance de la fin du XIXe si�cle.", "La Naissance de V�nus de Botticelli est une peinture � l'huile sur toile r�alis�e vers 1485. Il repr�sente la d�esse V�nus sortant de l'eau, entour�e de personnages all�goriques et de d�cors inspir�s de la mythologie antique. La peinture est consid�r�e comme l'une des �uvres les plus importantes de Botticelli et est reconnue pour son utilisation innovante de la forme, de la couleur et des motifs pour cr�er une image sensuelle et �rotique. Il est souvent consid�r� comme une repr�sentation de la beaut� f�minine et de la sensualit�. Il a �t� peint pendant la Renaissance italienne, o� l'art �tait fortement influenc� par les th�mes de l'Antiquit� classique. La Naissance de V�nus de Botticelli est souvent consid�r�e comme un symbole de l'�panouissement de la femme et de la lib�ration sexuelle.", "" }; // descriptif oeuvre 

    [SerializeField] private Image targetImage;
    

   // private int currentImageIndex = 0;
    public Text descriptionText;


    // Start is called before the first frame update
    void Start()
    {    // chargement des images 
      //  targetImage.sprite = Resources.Load<Sprite>("Images/" + artWorkName[currentImageIndex]);
     
    }

    // Update is called once per frame
    void Update()
    {

    }



   /* public void ShowNextImage()
    {
        // limite de ce code est que d�s que cela d�passe l'index pr�d�fini on revient � l'index 0
        currentImageIndex++;
        if (currentImageIndex >= artWorkName.Length)
        {
            currentImageIndex = 0;
        }

        // chargement du sprite en utilisant resources Load pour le definir comme targetImage
        Sprite sprite = Resources.Load<Sprite>("Images/" + artWorkName[currentImageIndex]);
        targetImage.sprite = sprite;

        descriptionText.text = description[currentImageIndex];
    }*/


}
