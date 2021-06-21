# SequencerTest
A simple one screen app with Unity.

Using Unity Version:
* 2019.3.4f1

The buttons at the top do not load presets. I was trying to implement this using PlayerPrefs, but was unable to
make it functional in the time I had to spend on it.

The sequencer is monophonic.

There is a bug where deselecting a note causes the sequence to stop. I believe this is due to the way I programmed the 
PlayColumn() function in the PlayQuantizedNotes class.

The first thing I would add to the sequencer to make it more interesting would be a tempo change functionality. The bpm variable 
in the BPM class is already exposed in the inspector so it would be easy to add a slider to allow the user to control it.
